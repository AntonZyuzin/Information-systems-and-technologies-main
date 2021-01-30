package com.vgu.cs.course2.group11.yakovlev_n_je;

public class Main {

    public static void main(String[] args) {
        Library htmlLibrary = new Library();
        CodeBlock block = new CodeBlock("Текст");
        TextParagraph paragraph = new TextParagraph("Текст");
        htmlLibrary.addElement(block);
        htmlLibrary.addElement(paragraph);
        htmlLibrary.createCode();
    }
}
