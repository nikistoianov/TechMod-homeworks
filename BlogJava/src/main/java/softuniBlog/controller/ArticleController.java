package softuniBlog.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.access.prepost.PreAuthorize;
import org.springframework.security.core.context.SecurityContextHolder;
import org.springframework.security.core.userdetails.UserDetails;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import softuniBlog.bindingModel.ArticleBindingModel;
import softuniBlog.entity.Article;
import softuniBlog.entity.User;
import softuniBlog.repository.ArticleRepository;
import softuniBlog.repository.UserRepository;

@Controller
public class ArticleController {
    @Autowired
    private ArticleRepository articleRepository;
    @Autowired
    private UserRepository userRepository;

    @GetMapping("/article/create")
    @PreAuthorize("isAuthenticated()")
    public String create(Model model) {
        model.addAttribute("view", "article/create");
        return "base-layout";
    }

    @PostMapping("/article/create")
    @PreAuthorize("isAuthenticated()")
    public String create(Model model, ArticleBindingModel articleFormData) {
        try {
            UserDetails userDetails = (UserDetails) SecurityContextHolder.getContext().getAuthentication().getPrincipal();
            User user = this.userRepository.findByEmail(userDetails.getUsername());

            Article article = new Article(
                    articleFormData.getTitle(),
                    articleFormData.getContent(),
                    user
            );
            this.articleRepository.saveAndFlush(article);

            return "redirect:/";
        } catch (Exception ex) {
            model.addAttribute("errorMsg", "Error creating article!");
            model.addAttribute("view", "article/create");
            return "base-layout";
        }
    }

    @GetMapping("/article/{id}")
    public String details(Model model, @PathVariable Integer id) {
        if (!this.articleRepository.exists(id)) {
            return "redirect:/";
        }

        Article article = this.articleRepository.findOne(id);

        model.addAttribute("article", article);
        model.addAttribute("view", "article/details");
        return "base-layout";
    }

    @GetMapping("/article/edit/{id}")
    @PreAuthorize("isAuthenticated()")
    public String editArticle(@PathVariable Integer id, Model model) {
        if (!this.articleRepository.exists(id)) {
            return "redirect:/";
        }

        Article article = this.articleRepository.findOne(id);

        model.addAttribute("article", article);
        model.addAttribute("view", "article/edit");
        return "base-layout";
    }

    @PostMapping("/article/edit/{id}")
    @PreAuthorize("isAuthenticated()")
    public String editArticle(@PathVariable Integer id, Model model,ArticleBindingModel articleFormData) {
        if (!this.articleRepository.exists(id)) {
            return "redirect:/";
        }
        Article article = this.articleRepository.findOne(id);

        try {
            article.setTitle(articleFormData.getTitle());
            article.setContent(articleFormData.getContent());
            this.articleRepository.saveAndFlush(article);

            return "redirect:/article/{id}";
        } catch (Exception ex) {
            model.addAttribute("errorMsg", "Error editing article!");
            model.addAttribute("article", article);
            model.addAttribute("view", "article/edit");
            return "base-layout";
        }
    }

    @GetMapping("/article/delete/{id}")
    @PreAuthorize("isAuthenticated()")
    public String delete(@PathVariable Integer id, Model model) {
        if (!this.articleRepository.exists(id)) {
            return "redirect:/";
        }

        Article article = this.articleRepository.findOne(id);

        model.addAttribute("article", article);
        model.addAttribute("view", "article/delete");
        return "base-layout";
    }

    @PostMapping("/article/delete/{id}")
    @PreAuthorize("isAuthenticated()")
    public String deletePost(@PathVariable Integer id, Model model) {
        if (!this.articleRepository.exists(id)) {
            return "redirect:/";
        }

        Article article = this.articleRepository.findOne(id);
        try {
            this.articleRepository.delete(article);
            return "redirect:/";
        } catch (Exception ex) {
            model.addAttribute("errorMsg", "Error deleting article!");
            model.addAttribute("article", article);
            model.addAttribute("view", "article/delete");
            return "base-layout";
        }
    }
}
