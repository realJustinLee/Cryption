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
	private JTextField textFieldCrySrc;
	private JTextField textFieldCryDes;
	private JTextField textFieldDecSrc;
	private JTextField textFieldDecDes;
	private JTextField textFieldSetAesPwd;
	private JTextField textFieldInputAesPwd;

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
		
		JLabel labelTitle = new JLabel("\u52A0\u5BC6\u4E0E\u89E3\u5BC6\u7B97\u6CD5\u6D4B\u8BD5");
		labelTitle.setForeground(new Color(30, 144, 255));
		labelTitle.setFont(new Font("PingFang SC", Font.PLAIN, 36));
		labelTitle.setBounds(170, 40, 500, 80);
		contentPane.add(labelTitle);
		
		JTabbedPane tabbedPanelAlgorithm = new JTabbedPane(JTabbedPane.TOP);
		tabbedPanelAlgorithm.setFont(new Font("PingFang SC", Font.PLAIN, 16));
		tabbedPanelAlgorithm.setBounds(170, 130, 486, 560);
		contentPane.add(tabbedPanelAlgorithm);
		
		JPanel panelAESAndSHA = new JPanel();
		panelAESAndSHA.setBackground(Color.WHITE);
		tabbedPanelAlgorithm.addTab("AES 和 SHA", null, panelAESAndSHA, null);
		panelAESAndSHA.setLayout(null);
		
		JLabel labelAes = new JLabel("AES\u7B97\u6CD5\u6D4B\u8BD5");
		labelAes.setForeground(new Color(30, 144, 255));
		labelAes.setFont(new Font("PingFang SC", Font.PLAIN, 16));
		labelAes.setBounds(27, 10, 93, 29);
		panelAESAndSHA.add(labelAes);
		
		JLabel labelSetAesPwd = new JLabel("\u8BBE\u7F6E\u5BC6\u7801\uFF1A");
		labelSetAesPwd.setFont(new Font("PingFang SC", Font.PLAIN, 12));
		labelSetAesPwd.setBounds(60, 50, 60, 15);
		panelAESAndSHA.add(labelSetAesPwd);
		
		textFieldSetAesPwd = new JTextField();
		textFieldSetAesPwd.setBounds(130, 46, 220, 21);
		panelAESAndSHA.add(textFieldSetAesPwd);
		textFieldSetAesPwd.setColumns(10);
		
		JButton buttonEnAes = new JButton("加密");
		buttonEnAes.setBounds(362, 43, 93, 29);
		panelAESAndSHA.add(buttonEnAes);
		
		JLabel labelInputAesPwd = new JLabel("输入密码：");
		labelInputAesPwd.setFont(new Font("PingFang SC", Font.PLAIN, 12));
		labelInputAesPwd.setBounds(60, 82, 60, 15);
		panelAESAndSHA.add(labelInputAesPwd);
		
		textFieldInputAesPwd = new JTextField();
		textFieldInputAesPwd.setBounds(130, 79, 220, 21);
		panelAESAndSHA.add(textFieldInputAesPwd);
		textFieldInputAesPwd.setColumns(10);
		
		JButton buttonDeAes = new JButton("解密");
		buttonDeAes.setBounds(362, 76, 93, 29);
		panelAESAndSHA.add(buttonDeAes);
		
		JLabel labelSha = new JLabel("SHA算法测试");
		labelSha.setForeground(new Color(30, 144, 255));
		labelSha.setFont(new Font("PingFang SC", Font.PLAIN, 16));
		labelSha.setBounds(27, 109, 104, 29);
		panelAESAndSHA.add(labelSha);
		
		JRadioButton rdbtnSha1 = new JRadioButton(" SHA 1");
		rdbtnSha1.setSelected(true);
		rdbtnSha1.setBounds(60, 150, 82, 23);
		panelAESAndSHA.add(rdbtnSha1);
		
		JRadioButton rdbtnSha256 = new JRadioButton("SHA 256");
		rdbtnSha256.setBounds(154, 150, 93, 23);
		panelAESAndSHA.add(rdbtnSha256);
		
		JRadioButton rdbtnSha512 = new JRadioButton("SHA 512");
		rdbtnSha512.setBounds(258, 150, 93, 23);
		panelAESAndSHA.add(rdbtnSha512);
		
		JButton buttonSha = new JButton("加密");
		buttonSha.setBounds(362, 149, 93, 29);
		panelAESAndSHA.add(buttonSha);
		
		JPanel panelMD5AndDES = new JPanel();
		panelMD5AndDES.setBackground(Color.WHITE);
		tabbedPanelAlgorithm.addTab("MD5 和 DES", null, panelMD5AndDES, null);
		panelMD5AndDES.setLayout(null);
		
		JLabel labelMd5 = new JLabel("MD5算法测试");
		labelMd5.setForeground(new Color(30, 144, 255));
		labelMd5.setFont(new Font("PingFang SC", Font.PLAIN, 16));
		labelMd5.setBounds(27, 10, 104, 29);
		panelMD5AndDES.add(labelMd5);
		
		JPanel panelRSA = new JPanel();
		panelRSA.setBackground(Color.WHITE);
		tabbedPanelAlgorithm.addTab("RSA 加密", null, panelRSA, null);
		panelRSA.setLayout(null);
		
		JPanel panelCertification = new JPanel();
		panelCertification.setBackground(Color.WHITE);
		tabbedPanelAlgorithm.addTab("创建证书", null, panelCertification, null);
		panelCertification.setLayout(null);
		
		JLabel labelCrySrc = new JLabel("\u5F85\u52A0\u5BC6\u6587\u672C");
		labelCrySrc.setFont(new Font("PingFang SC", Font.PLAIN, 12));
		labelCrySrc.setBounds(701, 130, 60, 22);
		contentPane.add(labelCrySrc);
		
		textFieldCrySrc = new JTextField();
		textFieldCrySrc.setBounds(699, 162, 400, 100);
		contentPane.add(textFieldCrySrc);
		textFieldCrySrc.setColumns(10);
		
		JLabel labelCryDes = new JLabel("\u52A0\u5BC6\u540E\u7684\u6587\u672C");
		labelCryDes.setFont(new Font("PingFang SC", Font.PLAIN, 12));
		labelCryDes.setBounds(699, 272, 72, 22);
		contentPane.add(labelCryDes);
		
		textFieldCryDes = new JTextField();
		textFieldCryDes.setEnabled(false);
		textFieldCryDes.setBounds(699, 304, 400, 100);
		contentPane.add(textFieldCryDes);
		textFieldCryDes.setColumns(10);
		
		JLabel labelDecSrc = new JLabel("\u5F85\u89E3\u5BC6/\u8BA4\u8BC1\u6587\u672C");
		labelDecSrc.setFont(new Font("PingFang SC", Font.PLAIN, 12));
		labelDecSrc.setBounds(699, 414, 93, 22);
		contentPane.add(labelDecSrc);
		
		textFieldDecSrc = new JTextField();
		textFieldDecSrc.setBounds(699, 448, 400, 100);
		contentPane.add(textFieldDecSrc);
		textFieldDecSrc.setColumns(10);
		
		JLabel labelDecDes = new JLabel("\u89E3\u5BC6/\u8BA4\u8BC1\u540E\u7684\u6587\u672C");
		labelDecDes.setFont(new Font("PingFang SC", Font.PLAIN, 12));
		labelDecDes.setBounds(699, 558, 102, 22);
		contentPane.add(labelDecDes);
		
		textFieldDecDes = new JTextField();
		textFieldDecDes.setEnabled(false);
		textFieldDecDes.setBounds(699, 590, 400, 100);
		contentPane.add(textFieldDecDes);
		textFieldDecDes.setColumns(10);
		
		JButton buttonClear = new JButton("\u6E05\u7A7A\u6570\u636E");
		buttonClear.setBounds(1006, 133, 93, 29);
		contentPane.add(buttonClear);
		buttonClear.setFont(new Font("PingFang SC", Font.PLAIN, 12));
	}
}
