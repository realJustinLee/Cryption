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
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class MainFrame extends JFrame {

	private JPanel contentPane;
	private JTextField textFieldCrySrc;
	private JTextField textFieldCryDes;
	private JTextField textFieldDecSrc;
	private JTextField textFieldDecDes;
	private JTextField textFieldSetAesPwd;
	private JTextField textFieldInputAesPwd;
	private JTextField textFieldMd5Des;
	private JTextField textFieldMd5Src;
	private JTextField textFieldSetDesPwd;
	private JTextField textFieldIputDesPwd;

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
		labelAes.setBounds(27, 10, 100, 29);
		panelAESAndSHA.add(labelAes);
		
		JLabel labelSetAesPwd = new JLabel("\u8BBE\u7F6E\u5BC6\u7801\uFF1A");
		labelSetAesPwd.setFont(new Font("PingFang SC", Font.PLAIN, 13));
		labelSetAesPwd.setBounds(58, 48, 69, 16);
		panelAESAndSHA.add(labelSetAesPwd);
		
		textFieldSetAesPwd = new JTextField();
		textFieldSetAesPwd.setFont(new Font("PingFang SC", Font.PLAIN, 13));
		textFieldSetAesPwd.setBounds(139, 43, 191, 26);
		panelAESAndSHA.add(textFieldSetAesPwd);
		textFieldSetAesPwd.setColumns(10);
		
		JButton buttonEnAes = new JButton("加密");
		buttonEnAes.setFont(new Font("PingFang SC", Font.PLAIN, 13));
		buttonEnAes.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
			}
		});
		buttonEnAes.setBounds(342, 43, 117, 29);
		panelAESAndSHA.add(buttonEnAes);
		
		JLabel labelInputAesPwd = new JLabel("输入密码：");
		labelInputAesPwd.setFont(new Font("PingFang SC", Font.PLAIN, 13));
		labelInputAesPwd.setBounds(58, 80, 69, 16);
		panelAESAndSHA.add(labelInputAesPwd);
		
		textFieldInputAesPwd = new JTextField();
		textFieldInputAesPwd.setFont(new Font("PingFang SC", Font.PLAIN, 13));
		textFieldInputAesPwd.setBounds(139, 75, 191, 26);
		panelAESAndSHA.add(textFieldInputAesPwd);
		textFieldInputAesPwd.setColumns(10);
		
		JButton buttonDeAes = new JButton("解密");
		buttonDeAes.setFont(new Font("PingFang SC", Font.PLAIN, 13));
		buttonDeAes.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
			}
		});
		buttonDeAes.setBounds(342, 75, 117, 29);
		panelAESAndSHA.add(buttonDeAes);
		
		JLabel labelSha = new JLabel("SHA算法测试");
		labelSha.setForeground(new Color(30, 144, 255));
		labelSha.setFont(new Font("PingFang SC", Font.PLAIN, 16));
		labelSha.setBounds(27, 109, 100, 29);
		panelAESAndSHA.add(labelSha);
		
		JRadioButton rdbtnSha1 = new JRadioButton(" SHA 1");
		rdbtnSha1.setFont(new Font("PingFang SC", Font.PLAIN, 13));
		rdbtnSha1.setSelected(true);
		rdbtnSha1.setBounds(58, 151, 76, 23);
		panelAESAndSHA.add(rdbtnSha1);
		
		JRadioButton rdbtnSha256 = new JRadioButton("SHA 256");
		rdbtnSha256.setFont(new Font("PingFang SC", Font.PLAIN, 13));
		rdbtnSha256.setBounds(146, 151, 86, 23);
		panelAESAndSHA.add(rdbtnSha256);
		
		JRadioButton rdbtnSha512 = new JRadioButton("SHA 512");
		rdbtnSha512.setFont(new Font("PingFang SC", Font.PLAIN, 13));
		rdbtnSha512.setBounds(244, 151, 86, 23);
		panelAESAndSHA.add(rdbtnSha512);
		
		JButton buttonSha = new JButton("加密");
		buttonSha.setFont(new Font("PingFang SC", Font.PLAIN, 13));
		buttonSha.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
			}
		});
		buttonSha.setBounds(342, 150, 117, 29);
		panelAESAndSHA.add(buttonSha);
		
		JPanel panelMD5AndDES = new JPanel();
		panelMD5AndDES.setBackground(Color.WHITE);
		tabbedPanelAlgorithm.addTab("MD5 和 DES", null, panelMD5AndDES, null);
		panelMD5AndDES.setLayout(null);
		
		JLabel labelMd5 = new JLabel("MD5算法测试");
		labelMd5.setForeground(new Color(30, 144, 255));
		labelMd5.setFont(new Font("PingFang SC", Font.PLAIN, 16));
		labelMd5.setBounds(27, 10, 100, 29);
		panelMD5AndDES.add(labelMd5);
		
		JLabel labelMdsDes = new JLabel("MD5值：");
		labelMdsDes.setFont(new Font("PingFang SC", Font.PLAIN, 13));
		labelMdsDes.setBounds(72, 51, 55, 16);
		panelMD5AndDES.add(labelMdsDes);
		
		textFieldMd5Des = new JTextField();
		textFieldMd5Des.setFont(new Font("PingFang SC", Font.PLAIN, 13));
		textFieldMd5Des.setBounds(139, 46, 195, 60);
		panelMD5AndDES.add(textFieldMd5Des);
		textFieldMd5Des.setColumns(10);
		
		JButton buttonCalcMd5 = new JButton("计算");
		buttonCalcMd5.setFont(new Font("PingFang SC", Font.PLAIN, 13));
		buttonCalcMd5.setBounds(342, 46, 117, 29);
		panelMD5AndDES.add(buttonCalcMd5);
		
		JLabel labelMd5Src = new JLabel("验证文本：");
		labelMd5Src.setFont(new Font("PingFang SC", Font.PLAIN, 13));
		labelMd5Src.setBounds(62, 123, 65, 16);
		panelMD5AndDES.add(labelMd5Src);
		
		textFieldMd5Src = new JTextField();
		textFieldMd5Src.setFont(new Font("PingFang SC", Font.PLAIN, 13));
		textFieldMd5Src.setBounds(139, 118, 195, 100);
		panelMD5AndDES.add(textFieldMd5Src);
		textFieldMd5Src.setColumns(10);
		
		JButton buttonImportSrc = new JButton("导入");
		buttonImportSrc.setFont(new Font("PingFang SC", Font.PLAIN, 13));
		buttonImportSrc.setBounds(342, 118, 117, 29);
		panelMD5AndDES.add(buttonImportSrc);
		
		JLabel labelMd5Verification = new JLabel("验证结果：");
		labelMd5Verification.setFont(new Font("PingFang SC", Font.PLAIN, 13));
		labelMd5Verification.setBounds(62, 230, 65, 16);
		panelMD5AndDES.add(labelMd5Verification);
		
		JLabel labelMd5VerificationResult = new JLabel("未知");
		labelMd5VerificationResult.setFont(new Font("PingFang SC", Font.PLAIN, 13));
		labelMd5VerificationResult.setHorizontalAlignment(SwingConstants.CENTER);
		labelMd5VerificationResult.setBounds(139, 230, 195, 16);
		panelMD5AndDES.add(labelMd5VerificationResult);
		
		JButton buttonVerifyMd5 = new JButton("验证");
		buttonVerifyMd5.setFont(new Font("PingFang SC", Font.PLAIN, 13));
		buttonVerifyMd5.setBounds(342, 225, 117, 29);
		panelMD5AndDES.add(buttonVerifyMd5);
		
		JLabel labelDes = new JLabel("DES算法测试");
		labelDes.setForeground(new Color(30, 144, 255));
		labelDes.setFont(new Font("PingFang SC", Font.PLAIN, 16));
		labelDes.setBounds(27, 258, 100, 29);
		panelMD5AndDES.add(labelDes);
		
		JLabel labelSetDesPwd = new JLabel("设置密码：");
		labelSetDesPwd.setFont(new Font("PingFang SC", Font.PLAIN, 13));
		labelSetDesPwd.setBounds(58, 304, 69, 16);
		panelMD5AndDES.add(labelSetDesPwd);
		
		textFieldSetDesPwd = new JTextField();
		textFieldSetDesPwd.setFont(new Font("PingFang SC", Font.PLAIN, 13));
		textFieldSetDesPwd.setColumns(10);
		textFieldSetDesPwd.setBounds(139, 299, 191, 26);
		panelMD5AndDES.add(textFieldSetDesPwd);
		
		JButton buttonEnDes = new JButton("加密");
		buttonEnDes.setFont(new Font("PingFang SC", Font.PLAIN, 13));
		buttonEnDes.setBounds(342, 299, 117, 29);
		panelMD5AndDES.add(buttonEnDes);
		
		JLabel labelInputDesPwd = new JLabel("输入密码：");
		labelInputDesPwd.setFont(new Font("PingFang SC", Font.PLAIN, 13));
		labelInputDesPwd.setBounds(58, 336, 69, 16);
		panelMD5AndDES.add(labelInputDesPwd);
		
		textFieldIputDesPwd = new JTextField();
		textFieldIputDesPwd.setFont(new Font("PingFang SC", Font.PLAIN, 13));
		textFieldIputDesPwd.setColumns(10);
		textFieldIputDesPwd.setBounds(139, 331, 191, 26);
		panelMD5AndDES.add(textFieldIputDesPwd);
		
		JButton buttonDeDes = new JButton("解密");
		buttonDeDes.setFont(new Font("PingFang SC", Font.PLAIN, 13));
		buttonDeDes.setBounds(342, 331, 117, 29);
		panelMD5AndDES.add(buttonDeDes);
		
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
		textFieldCrySrc.setFont(new Font("PingFang SC", Font.PLAIN, 13));
		textFieldCrySrc.setBounds(699, 162, 400, 100);
		contentPane.add(textFieldCrySrc);
		textFieldCrySrc.setColumns(10);
		
		JLabel labelCryDes = new JLabel("\u52A0\u5BC6\u540E\u7684\u6587\u672C");
		labelCryDes.setFont(new Font("PingFang SC", Font.PLAIN, 12));
		labelCryDes.setBounds(699, 272, 72, 22);
		contentPane.add(labelCryDes);
		
		textFieldCryDes = new JTextField();
		textFieldCryDes.setFont(new Font("PingFang SC", Font.PLAIN, 13));
		textFieldCryDes.setEnabled(false);
		textFieldCryDes.setBounds(699, 304, 400, 100);
		contentPane.add(textFieldCryDes);
		textFieldCryDes.setColumns(10);
		
		JLabel labelDecSrc = new JLabel("\u5F85\u89E3\u5BC6/\u8BA4\u8BC1\u6587\u672C");
		labelDecSrc.setFont(new Font("PingFang SC", Font.PLAIN, 12));
		labelDecSrc.setBounds(699, 414, 93, 22);
		contentPane.add(labelDecSrc);
		
		textFieldDecSrc = new JTextField();
		textFieldDecSrc.setFont(new Font("PingFang SC", Font.PLAIN, 13));
		textFieldDecSrc.setBounds(699, 448, 400, 100);
		contentPane.add(textFieldDecSrc);
		textFieldDecSrc.setColumns(10);
		
		JLabel labelDecDes = new JLabel("\u89E3\u5BC6/\u8BA4\u8BC1\u540E\u7684\u6587\u672C");
		labelDecDes.setFont(new Font("PingFang SC", Font.PLAIN, 12));
		labelDecDes.setBounds(699, 558, 102, 22);
		contentPane.add(labelDecDes);
		
		textFieldDecDes = new JTextField();
		textFieldDecDes.setFont(new Font("PingFang SC", Font.PLAIN, 13));
		textFieldDecDes.setEnabled(false);
		textFieldDecDes.setBounds(699, 590, 400, 100);
		contentPane.add(textFieldDecDes);
		textFieldDecDes.setColumns(10);
		
		JButton buttonClear = new JButton("\u6E05\u7A7A\u6570\u636E");
		buttonClear.setBounds(982, 134, 117, 29);
		contentPane.add(buttonClear);
		buttonClear.setFont(new Font("PingFang SC", Font.PLAIN, 12));
	}
}
