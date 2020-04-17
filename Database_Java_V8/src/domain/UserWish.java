package domain;

import java.io.Serializable;

public class UserWish  implements Serializable {
    private String ID;
    private String URL;
    private String Title;

    public UserWish(String username, String URL, String Title) {
        this.ID = username;
        this.URL = URL;
        this.Title = Title;

    }


    public String getUsername() {
        return ID;
    }

    public void setUsername(String username) {
        this.ID = username;
    }

    public String getURL() {
        return URL;
    }

    public void setURL(String URL) {
        this.URL = URL;
    }

    public String getTitle() {
        return Title;
    }

    public void setTitle(String title) {
        Title = title;
    }

    @Override
    public String toString() {
        return "Username='" + ID + '\'' +
                ", URL='" + URL + '\'' +
                ", Title='" + Title + '\'';

    }
}
