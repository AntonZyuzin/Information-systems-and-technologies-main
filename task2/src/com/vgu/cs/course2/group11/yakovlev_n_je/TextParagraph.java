package com.vgu.cs.course2.group11.yakovlev_n_je;

public class TextParagraph implements Element {

    private String text;

    public TextParagraph(String text) {
        this.text = text;
    }

    public String getText() {
        return text;
    }

    public void setText(String value) {
        text = value;
    }

    @Override
    public String render() {
        return String.format("<p>%s</p>", text);
    }
}
