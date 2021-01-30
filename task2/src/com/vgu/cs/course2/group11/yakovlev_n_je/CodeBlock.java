package com.vgu.cs.course2.group11.yakovlev_n_je;

public class CodeBlock implements Element{

    private String text;

    public CodeBlock(String text) {
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
        return String.format("<div>%s</div>", text);
    }
}
