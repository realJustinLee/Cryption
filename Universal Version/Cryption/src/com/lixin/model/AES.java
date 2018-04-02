package com.lixin.model;

import javax.crypto.Cipher;
import javax.crypto.KeyGenerator;
import javax.crypto.SecretKey;
import javax.crypto.spec.SecretKeySpec;
import java.nio.ByteBuffer;
import java.security.SecureRandom;
import java.util.Base64;

public class AES {
    public static String AESEncoder(String content, String password) {
        try {
            //1.构造密钥生成器，指定为AES算法,不区分大小写
            KeyGenerator keyGenerator = KeyGenerator.getInstance("AES");
            //2.根据password初始化密钥生成器
            //生成一个128位的随机源,根据传入的字节数组
            keyGenerator.init(128, new SecureRandom(password.getBytes()));
            //3.产生原始对称密钥
            SecretKey rawKey = keyGenerator.generateKey();
            //4.获得原始对称密钥的字节数组
            byte[] raw = rawKey.getEncoded();
            //5.根据字节数组生成AES密钥
            SecretKey key = new SecretKeySpec(raw, "AES");
            //6.根据指定算法AES自成密码器
            Cipher cipher = Cipher.getInstance("AES");
            //7.初始化密码器，第一个参数为加密(Encrypt_mode)或者解密解密(Decrypt_mode)操作，第二个参数为使用的KEY
            cipher.init(Cipher.ENCRYPT_MODE, key);
            //8.获取加密内容的字节数组(这里要设置为utf-8)不然内容中如果有中文和英文混合中文就会解密为乱码
            byte[] contentBytes = content.getBytes("utf-8");
            //9.根据密码器的初始化方式--加密：将数据加密
            byte[] encryptedBytes = cipher.doFinal(contentBytes);
            //10.将加密后的数据转换为字符串并返回
            return new String(Base64.getEncoder().encode(encryptedBytes));
        } catch (Exception e) {
            e.printStackTrace();
            return null;
        }
    }

    public static String AESDecoder(String content, String password) {
        try {
            //1.构造密钥生成器，指定为AES算法,不区分大小写
            KeyGenerator keyGenerator = KeyGenerator.getInstance("AES");
            //2.根据password初始化密钥生成器
            //生成一个128位的随机源,根据传入的字节数组
            keyGenerator.init(128, new SecureRandom(password.getBytes()));
            //3.产生原始对称密钥
            SecretKey rawKey = keyGenerator.generateKey();
            //4.获得原始对称密钥的字节数组
            byte[] raw = rawKey.getEncoded();
            //5.根据字节数组生成AES密钥
            SecretKey key = new SecretKeySpec(raw, "AES");
            //6.根据指定算法AES自成密码器
            Cipher cipher = Cipher.getInstance("AES");
            //7.初始化密码器，第一个参数为加密(Encrypt_mode)或者解密解密(Decrypt_mode)操作，第二个参数为使用的KEY
            cipher.init(Cipher.DECRYPT_MODE, key);
            //8.将加密并编码后的内容解码成字节数组
            byte[] contentBytes = Base64.getDecoder().decode(content.getBytes());
            //TODO: Fix this fucking BUG
            byte[] decryptedBytes = cipher.doFinal(contentBytes);
            //10.将加密后的数据转换为字符串并返回
            return new String(decryptedBytes, "utf-8");
        } catch (Exception e) {
            e.printStackTrace();
            return null;
        }
    }
}
