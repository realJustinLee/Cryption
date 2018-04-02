import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JTabbedPane;
import javax.swing.JTextField;
import javax.swing.JButton;
import javax.swing.JLabel;
import java.awt.Font;
import javax.swing.SwingConstants;
import javax.swing.JToggleButton;
import javax.swing.JRadioButton;
import java.awt.Color;
import java.awt.SystemColor;

public class MainFrame extends JFrame {

	private JPanel contentPane;
	private JTextField textField;
	private JTextField textField_1;
	private JTextField textField_2;
	private JTextField textField_3;
	private JTextField textField_4;
	private JTextField textField_5;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					MainFrame frame = new MainFrame();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the frame.
	 */
	public MainFrame() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 1280, 768);
		contentPane = new JPanel();
		contentPane.setBackground(new Color(240, 248, 255));
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JLabel label = new JLabel("\u52A0\u5BC6\u4E0E\u89E3\u5BC6\u7B97\u6CD5\u6D4B\u8BD5");
		label.setForeground(new Color(30, 144, 255));
		label.setFont(new Font("΢���ź�", Font.PLAIN, 36));
		label.setBounds(170, 40, 500, 80);
		contentPane.add(label);
		
		JTabbedPane tabbedPane = new JTabbedPane(JTabbedPane.TOP);
		tabbedPane.setFont(new Font("΢���ź�", Font.PLAIN, 16));
		tabbedPane.setBounds(170, 130, 486, 560);
		contentPane.add(tabbedPane);
		
		JPanel panel = new JPanel();
		panel.setBackground(Color.WHITE);
		tabbedPane.addTab("AES 和 SHA", null, panel, null);
		panel.setLayout(null);
		
		JLabel lblNewLabel_1 = new JLabel("AES\u7B97\u6CD5\u6D4B\u8BD5");
		lblNewLabel_1.setForeground(new Color(30, 144, 255));
		lblNewLabel_1.setFont(new Font("΢���ź�", Font.PLAIN, 16));
		lblNewLabel_1.setBounds(27, 10, 93, 29);
		panel.add(lblNewLabel_1);
		
		JLabel label_4 = new JLabel("\u8BBE\u7F6E\u5BC6\u7801\uFF1A");
		label_4.setFont(new Font("΢���ź�", Font.PLAIN, 12));
		label_4.setBounds(60, 49, 60, 15);
		panel.add(label_4);
		
		textField_4 = new JTextField();
		textField_4.setBounds(130, 46, 220, 21);
		panel.add(textField_4);
		textField_4.setColumns(10);
		
		JButton btnNewButton = new JButton("加密");
		btnNewButton.setBounds(362, 149, 93, 29);
		panel.add(btnNewButton);
		
		JLabel label_5 = new JLabel("输入密码：");
		label_5.setFont(new Font("΢���ź�", Font.PLAIN, 12));
		label_5.setBounds(60, 82, 60, 15);
		panel.add(label_5);
		
		textField_5 = new JTextField();
		textField_5.setBounds(130, 79, 220, 21);
		panel.add(textField_5);
		textField_5.setColumns(10);
		
		JButton btnNewButton_1 = new JButton("解密");
		btnNewButton_1.setBounds(362, 76, 93, 29);
		panel.add(btnNewButton_1);
		
		JLabel label_6 = new JLabel("SHA算法测试");
		label_6.setForeground(new Color(30, 144, 255));
		label_6.setFont(new Font("Dialog", Font.PLAIN, 16));
		label_6.setBounds(27, 109, 104, 29);
		panel.add(label_6);
		
		JRadioButton rdbtnSha = new JRadioButton(" SHA 1");
		rdbtnSha.setSelected(true);
		rdbtnSha.setBounds(60, 150, 82, 23);
		panel.add(rdbtnSha);
		
		JRadioButton rdbtnNewRadioButton = new JRadioButton("SHA 256");
		rdbtnNewRadioButton.setBounds(154, 150, 93, 23);
		panel.add(rdbtnNewRadioButton);
		
		JRadioButton rdbtnSha_1 = new JRadioButton("SHA 512");
		rdbtnSha_1.setBounds(258, 150, 93, 23);
		panel.add(rdbtnSha_1);
		
		JButton button_1 = new JButton("加密");
		button_1.setBounds(362, 43, 93, 29);
		panel.add(button_1);
		
		JPanel panel_1 = new JPanel();
		panel_1.setBackground(Color.WHITE);
		tabbedPane.addTab("DES", null, panel_1, null);
		panel_1.setLayout(null);
		
		JPanel panel_2 = new JPanel();
		panel_2.setBackground(Color.WHITE);
		tabbedPane.addTab("公钥和私钥", null, panel_2, null);
		panel_2.setLayout(null);
		
		JPanel panel_3 = new JPanel();
		panel_3.setBackground(Color.WHITE);
		tabbedPane.addTab("数字证书", null, panel_3, null);
		panel_3.setLayout(null);
		
		JLabel lblNewLabel = new JLabel("\u5F85\u52A0\u5BC6\u6587\u672C");
		lblNewLabel.setFont(new Font("΢���ź�", Font.PLAIN, 12));
		lblNewLabel.setBounds(701, 130, 60, 22);
		contentPane.add(lblNewLabel);
		
		textField = new JTextField();
		textField.setBounds(699, 162, 400, 100);
		contentPane.add(textField);
		textField.setColumns(10);
		
		JLabel label_1 = new JLabel("\u52A0\u5BC6\u540E\u7684\u6587\u672C");
		label_1.setFont(new Font("΢���ź�", Font.PLAIN, 12));
		label_1.setBounds(699, 272, 72, 22);
		contentPane.add(label_1);
		
		textField_1 = new JTextField();
		textField_1.setEnabled(false);
		textField_1.setBounds(699, 304, 400, 100);
		contentPane.add(textField_1);
		textField_1.setColumns(10);
		
		JLabel label_2 = new JLabel("\u5F85\u89E3\u5BC6/\u8BA4\u8BC1\u6587\u672C");
		label_2.setFont(new Font("΢���ź�", Font.PLAIN, 12));
		label_2.setBounds(699, 414, 93, 22);
		contentPane.add(label_2);
		
		textField_2 = new JTextField();
		textField_2.setBounds(699, 448, 400, 100);
		contentPane.add(textField_2);
		textField_2.setColumns(10);
		
		JLabel label_3 = new JLabel("\u89E3\u5BC6/\u8BA4\u8BC1\u540E\u7684\u6587\u672C");
		label_3.setFont(new Font("΢���ź�", Font.PLAIN, 12));
		label_3.setBounds(699, 558, 102, 22);
		contentPane.add(label_3);
		
		textField_3 = new JTextField();
		textField_3.setEnabled(false);
		textField_3.setBounds(699, 590, 400, 100);
		contentPane.add(textField_3);
		textField_3.setColumns(10);
		
		JButton button = new JButton("\u6E05\u7A7A\u6570\u636E");
		button.setBounds(1006, 133, 93, 29);
		contentPane.add(button);
		button.setFont(new Font("΢���ź�", Font.PLAIN, 12));
	}
}
