package softuniBlog.entity;
import javax.persistence.*;

@Entity
@Table(name="articles")
public class Article {
    private Integer id;
    private String title;
    private String content;
    private User autor;

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    public Integer getId() {
        return id;
    }

    public void setId(Integer id) {
        this.id = id;
    }

    @Column(nullable = false)
    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    @Column(columnDefinition = "text", nullable = false)
    public String getContent() {
        return content;
    }

    public void setContent(String content) {
        this.content = content;
    }

    @ManyToOne()
    @JoinColumn(nullable = false, name = "authorId")
    public User getAutor() {
        return autor;
    }

    public void setAutor(User autor) {
        this.autor = autor;
    }

    public Article(String title, String content, User autor) {
        this.title = title;
        this.content = content;
        this.autor = autor;
    }

    public Article() {}
}
