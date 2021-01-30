package com.vgu.cs.course2.group11.yakovlev_n_je;

import java.util.ArrayList;
import java.util.List;

public class Library {
    private final List<Element> elements = new ArrayList<>();

    public void addElement(Element element) {
        elements.add(element);
    }

    public void removeElement(Element element) {
        elements.remove(element);
    }

    public void createCode() {
        System.out.println("Ваш отредактированный HTML код:\n");
        for (Element element : elements) {
            System.out.println(element.render());
        }
    }
}
