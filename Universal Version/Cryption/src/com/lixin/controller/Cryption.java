package com.lixin.controller;

import com.lixin.view.MainFrame;

import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class Cryption {
    MainFrame frame;

    /**
     * Launch the application.
     */
    public static void main(String[] args) {
        EventQueue.invokeLater(() -> {
            try {
                Cryption cryption = new Cryption();
            } catch (Exception e) {
                e.printStackTrace();
            }
        });
    }

    public Cryption() {
        frame = new MainFrame();
        frame.setVisible(true);
    }
}
