package com.lixin.view;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JTabbedPane;
import javax.swing.JTextField;
import javax.swing.JButton;
import javax.swing.JLabel;
import java.awt.Font;
import javax.swing.SwingConstants;
import javax.swing.JRadioButton;
import java.awt.Color;

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
    private JTextField textFieldInputDesPwd;
    private JTextField textFieldExportPfxRoute;
    private JTextField textFieldSetPfxPwd;
    private JTextField textFieldExportCerRoute;
    private JTextField textFieldImportPfxRoute;
    private JTextField textFieldInputPfxPwd;
    private JTextField textFieldPubKeySouw;
    private JTextField textFieldPrivateKey;
    private JTextField textFieldInputSignature;
    private JButton buttonExportAsCer;

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
//        buttonEnAes.addActionListener(new ActionListener() {
//            public void actionPerformed(ActionEvent e) {
//
//            }
//        });
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

        textFieldInputDesPwd = new JTextField();
        textFieldInputDesPwd.setFont(new Font("PingFang SC", Font.PLAIN, 13));
        textFieldInputDesPwd.setColumns(10);
        textFieldInputDesPwd.setBounds(139, 331, 191, 26);
        panelMD5AndDES.add(textFieldInputDesPwd);

        JButton buttonDeDes = new JButton("解密");
        buttonDeDes.setFont(new Font("PingFang SC", Font.PLAIN, 13));
        buttonDeDes.setBounds(342, 331, 117, 29);
        panelMD5AndDES.add(buttonDeDes);

        JPanel panelCertification = new JPanel();
        panelCertification.setBackground(Color.WHITE);
        tabbedPanelAlgorithm.addTab("创建证书", null, panelCertification, null);
        panelCertification.setLayout(null);

        JLabel labelOpenSsl = new JLabel("创建含有私钥的证书");
        labelOpenSsl.setForeground(new Color(30, 144, 255));
        labelOpenSsl.setFont(new Font("PingFang SC", Font.PLAIN, 16));
        labelOpenSsl.setBounds(27, 10, 144, 29);
        panelCertification.add(labelOpenSsl);

        JLabel labelSetSignatire = new JLabel("设置证书签名：");
        labelSetSignatire.setFont(new Font("PingFang SC", Font.PLAIN, 13));
        labelSetSignatire.setBounds(37, 56, 100, 16);
        panelCertification.add(labelSetSignatire);

        textFieldInputSignature = new JTextField();
        textFieldInputSignature.setFont(new Font("PingFang SC", Font.PLAIN, 13));
        textFieldInputSignature.setColumns(10);
        textFieldInputSignature.setBounds(139, 51, 191, 26);
        panelCertification.add(textFieldInputSignature);

        JButton buttonGenerateCertification = new JButton("生成");
        buttonGenerateCertification.setFont(new Font("PingFang SC", Font.PLAIN, 13));
        buttonGenerateCertification.setBounds(342, 51, 117, 29);
        panelCertification.add(buttonGenerateCertification);

        JLabel labelExportAsPfx = new JLabel("导出为PFX文件");
        labelExportAsPfx.setForeground(new Color(30, 144, 255));
        labelExportAsPfx.setFont(new Font("PingFang SC", Font.PLAIN, 16));
        labelExportAsPfx.setBounds(27, 84, 117, 29);
        panelCertification.add(labelExportAsPfx);

        JLabel labelExportPfxRoute = new JLabel("导出路径：");
        labelExportPfxRoute.setFont(new Font("PingFang SC", Font.PLAIN, 13));
        labelExportPfxRoute.setBounds(58, 128, 69, 16);
        panelCertification.add(labelExportPfxRoute);

        textFieldExportPfxRoute = new JTextField();
        textFieldExportPfxRoute.setFont(new Font("PingFang SC", Font.PLAIN, 13));
        textFieldExportPfxRoute.setColumns(10);
        textFieldExportPfxRoute.setBounds(139, 123, 191, 26);
        panelCertification.add(textFieldExportPfxRoute);

        JButton buttonSetExportPfxRoute = new JButton("浏览");
        buttonSetExportPfxRoute.setFont(new Font("PingFang SC", Font.PLAIN, 13));
        buttonSetExportPfxRoute.setBounds(342, 123, 117, 29);
        panelCertification.add(buttonSetExportPfxRoute);

        JLabel labelSetPfxPwd = new JLabel("设置密码：");
        labelSetPfxPwd.setFont(new Font("PingFang SC", Font.PLAIN, 13));
        labelSetPfxPwd.setBounds(58, 159, 69, 16);
        panelCertification.add(labelSetPfxPwd);

        textFieldSetPfxPwd = new JTextField();
        textFieldSetPfxPwd.setFont(new Font("PingFang SC", Font.PLAIN, 13));
        textFieldSetPfxPwd.setColumns(10);
        textFieldSetPfxPwd.setBounds(139, 155, 191, 26);
        panelCertification.add(textFieldSetPfxPwd);

        JButton buttonExportAsPfx = new JButton("导出");
        buttonExportAsPfx.setFont(new Font("PingFang SC", Font.PLAIN, 13));
        buttonExportAsPfx.setBounds(342, 155, 117, 29);
        panelCertification.add(buttonExportAsPfx);

        JLabel labelExportAsCer = new JLabel("导出为CER文件");
        labelExportAsCer.setForeground(new Color(30, 144, 255));
        labelExportAsCer.setFont(new Font("PingFang SC", Font.PLAIN, 16));
        labelExportAsCer.setBounds(27, 193, 117, 29);
        panelCertification.add(labelExportAsCer);

        JLabel labelExportCerRoute = new JLabel("导出路径：");
        labelExportCerRoute.setFont(new Font("PingFang SC", Font.PLAIN, 13));
        labelExportCerRoute.setBounds(58, 239, 69, 16);
        panelCertification.add(labelExportCerRoute);

        textFieldExportCerRoute = new JTextField();
        textFieldExportCerRoute.setFont(new Font("PingFang SC", Font.PLAIN, 13));
        textFieldExportCerRoute.setColumns(10);
        textFieldExportCerRoute.setBounds(139, 234, 191, 26);
        panelCertification.add(textFieldExportCerRoute);

        JButton buttonSetExportCerRoute = new JButton("浏览");
        buttonSetExportCerRoute.setFont(new Font("PingFang SC", Font.PLAIN, 13));
        buttonSetExportCerRoute.setBounds(342, 234, 117, 29);
        panelCertification.add(buttonSetExportCerRoute);

        buttonExportAsCer = new JButton("导出");
        buttonExportAsCer.setFont(new Font("PingFang SC", Font.PLAIN, 13));
        buttonExportAsCer.setBounds(342, 266, 117, 29);
        panelCertification.add(buttonExportAsCer);

        JPanel panelRSA = new JPanel();
        panelRSA.setBackground(Color.WHITE);
        tabbedPanelAlgorithm.addTab("RSA 加密", null, panelRSA, null);
        panelRSA.setLayout(null);

        JLabel labelPfxTest = new JLabel("PFX文件的作用");
        labelPfxTest.setForeground(new Color(30, 144, 255));
        labelPfxTest.setFont(new Font("PingFang SC", Font.PLAIN, 16));
        labelPfxTest.setBounds(27, 10, 115, 29);
        panelRSA.add(labelPfxTest);

        JLabel labelImportPfxRoute = new JLabel("文件路径：");
        labelImportPfxRoute.setFont(new Font("PingFang SC", Font.PLAIN, 13));
        labelImportPfxRoute.setBounds(58, 56, 69, 16);
        panelRSA.add(labelImportPfxRoute);

        textFieldImportPfxRoute = new JTextField();
        textFieldImportPfxRoute.setFont(new Font("PingFang SC", Font.PLAIN, 13));
        textFieldImportPfxRoute.setColumns(10);
        textFieldImportPfxRoute.setBounds(139, 51, 191, 26);
        panelRSA.add(textFieldImportPfxRoute);

        JButton buttonSetImportPfxRoute = new JButton("浏览");
        buttonSetImportPfxRoute.setFont(new Font("PingFang SC", Font.PLAIN, 13));
        buttonSetImportPfxRoute.setBounds(342, 51, 117, 29);
        panelRSA.add(buttonSetImportPfxRoute);

        JLabel labelInputPfxPwd = new JLabel("解密密码：");
        labelInputPfxPwd.setFont(new Font("PingFang SC", Font.PLAIN, 13));
        labelInputPfxPwd.setBounds(58, 88, 69, 16);
        panelRSA.add(labelInputPfxPwd);

        textFieldInputPfxPwd = new JTextField();
        textFieldInputPfxPwd.setFont(new Font("PingFang SC", Font.PLAIN, 13));
        textFieldInputPfxPwd.setColumns(10);
        textFieldInputPfxPwd.setBounds(139, 83, 191, 26);
        panelRSA.add(textFieldInputPfxPwd);

        JButton buttonGetKeysFromPfx = new JButton("取密钥对");
        buttonGetKeysFromPfx.setFont(new Font("PingFang SC", Font.PLAIN, 13));
        buttonGetKeysFromPfx.setBounds(342, 83, 117, 29);
        panelRSA.add(buttonGetKeysFromPfx);

        JLabel labelPublicKeyAndPrivateKey = new JLabel("私钥加密和公钥解密");
        labelPublicKeyAndPrivateKey.setForeground(new Color(30, 144, 255));
        labelPublicKeyAndPrivateKey.setFont(new Font("PingFang SC", Font.PLAIN, 16));
        labelPublicKeyAndPrivateKey.setBounds(27, 116, 144, 29);
        panelRSA.add(labelPublicKeyAndPrivateKey);

        JLabel labelPfxMd5 = new JLabel("证书MD5：");
        labelPfxMd5.setFont(new Font("PingFang SC", Font.PLAIN, 13));
        labelPfxMd5.setBounds(58, 157, 69, 16);
        panelRSA.add(labelPfxMd5);

        JLabel labelPfxMd5Result = new JLabel("未知");
        labelPfxMd5Result.setHorizontalAlignment(SwingConstants.CENTER);
        labelPfxMd5Result.setFont(new Font("PingFang SC", Font.PLAIN, 13));
        labelPfxMd5Result.setBounds(135, 157, 195, 16);
        panelRSA.add(labelPfxMd5Result);

        JLabel labelPfxName = new JLabel("证书名称：");
        labelPfxName.setFont(new Font("PingFang SC", Font.PLAIN, 13));
        labelPfxName.setBounds(62, 185, 65, 16);
        panelRSA.add(labelPfxName);

        JLabel labelGetPfxName = new JLabel("未知");
        labelGetPfxName.setHorizontalAlignment(SwingConstants.CENTER);
        labelGetPfxName.setFont(new Font("PingFang SC", Font.PLAIN, 13));
        labelGetPfxName.setBounds(135, 185, 195, 16);
        panelRSA.add(labelGetPfxName);

        JLabel labelPubKey = new JLabel("公钥：");
        labelPubKey.setFont(new Font("PingFang SC", Font.PLAIN, 13));
        labelPubKey.setBounds(88, 219, 39, 16);
        panelRSA.add(labelPubKey);

        textFieldPubKeySouw = new JTextField();
        textFieldPubKeySouw.setFont(new Font("PingFang SC", Font.PLAIN, 13));
        textFieldPubKeySouw.setColumns(10);
        textFieldPubKeySouw.setBounds(135, 213, 300, 80);
        panelRSA.add(textFieldPubKeySouw);

        JLabel labelPrivateKey = new JLabel("私钥：");
        labelPrivateKey.setToolTipText("               ");
        labelPrivateKey.setFont(new Font("PingFang SC", Font.PLAIN, 13));
        labelPrivateKey.setBounds(88, 305, 39, 16);
        panelRSA.add(labelPrivateKey);

        textFieldPrivateKey = new JTextField();
        textFieldPrivateKey.setFont(new Font("PingFang SC", Font.PLAIN, 13));
        textFieldPrivateKey.setColumns(10);
        textFieldPrivateKey.setBounds(135, 305, 300, 80);
        panelRSA.add(textFieldPrivateKey);

        JButton buttonEnCryptPrivate = new JButton("使用私钥加密");
        buttonEnCryptPrivate.setBounds(139, 397, 150, 29);
        panelRSA.add(buttonEnCryptPrivate);

        JButton buttonDeCryptPublic = new JButton("使用公钥解密");
        buttonDeCryptPublic.setBounds(285, 397, 150, 29);
        panelRSA.add(buttonDeCryptPublic);

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
