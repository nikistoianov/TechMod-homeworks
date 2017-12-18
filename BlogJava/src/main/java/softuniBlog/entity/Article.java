package softuniBlog.entity;

import org.hibernate.validator.constraints.Length;
import org.omg.PortableInterceptor.ServerRequestInfo;

import javax.persistence.*;

@Entity
@Table(name="articles")
public class Article {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Integer id;

    @Column(nullable = false)
    @Length(min = 1)
    private String title;

    @Column(columnDefinition = "text", nullable = false)
    @Length(min = 1)
    private String content;

    @ManyToOne()
    @JoinColumn(nullable = false, name = "authorId")
    private User author;

    public Article() {
    }

    public Article(String title, String content, User autor) {
        this.title = title;
        this.content = content;
        this.author = autor;
    }

    public Integer getId() {
        return id;
    }

    public void setId(Integer id) {
        this.id = id;
    }

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public String getContent() {
        return content;
    }

    public void setContent(String content) {
        this.content = content;
    }

    public User getAuthor() {
        return author;
    }

    public void setAuthor(User author) {
        this.author = author;
    }

    @Transient
    public String getSummary() {
        return this.getContent().substring(0, this.getContent().length() / 2) + "...";
    }
}
