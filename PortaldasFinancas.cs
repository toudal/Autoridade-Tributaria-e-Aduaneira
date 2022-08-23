
      // Generated csp request
      
      // The Password field must contain the (user/subuser) password, the same 
      // that is used to enter the Finance Portal. This Password must be encrypted 
      // using the symmetric key of the request (see Nonce field) and encoded in Base64.
      // Password := Base64(CKAESs,ECB,PKCS5Padding(PasswordPF))
      
      Byte[]
      lPassphrase = EcitCSPImpl.Encrypt(EcitHelper.ToByteArray(lPassword), lISP.ExportParameters(true));
      lPassbytes = Convert.ToBase64String(lPassphrase.ToArray());

      // Created := Base64(CKAESs,ECB,PKCS5Padding(Timestamp)) 
      // CKAESs,ECB,PKCS5Padding 
      // Cipher function using the AES algorithm, ECB Model, PKCS5Padding and the
      // symmetric key of the request (KS). Base64 := Base 64 encoding of the result
      //
      
      lCreated = Convert.ToBase64String(lUniversalTime.ToArray());

      EcitCSPImpl.Encrypt(lNonce, lPassword);
      
      
      // Created encryptor to perform the stream transform
      // lAlgorithm.Key = lCipher.Key;
      // lAlgorithm.IV = lCipher.IV;

      // Nonce:=Base64(CRSA,KpubSA(Ks)) 
      // Each invocation of the Webservice must contain a randomly generated key, which cannot be repeated. 
      // Create certificate instance and encrypt generated temporary symetric key
      // 
      // http://wiki.scn.sap.com/wiki/display/Security/Best+Practices+-+How+to+convert+certificates+from+a+.p7b+file+to+Base64+(.cer)+format
      
      // True to perform direct System.Security.Cryptography.RSA encryption using OAEP
      // padding (only available on a computer running Windows XP or later); otherwise,
      // false to use PKCS#1 v1.5 padding.
      Byte[] lNonce = AlgRSA.Encrypt(lAlgorithm.Key, false);
      
        //Byte[] test = AlgRSA.Decrypt(lNonce, false);
        //Console.WriteLine(" $€ >> " + Convert.ToBase64String(test));
