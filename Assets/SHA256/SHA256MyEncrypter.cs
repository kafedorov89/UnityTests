using UnityEngine;
//using System.Collections;
using System.Security.Cryptography;
//using System.Collections.Generic;
using System;
using System.Text;

public class SHA256MyEncrypter : MonoBehaviour {

    public string ComputeHash(string input, HashAlgorithm algorithm)
    {
        Byte[] inputBytes = Encoding.UTF8.GetBytes(input);
        Byte[] hashedBytes = algorithm.ComputeHash(inputBytes);
        return BitConverter.ToString(hashedBytes);
    }

    // Use this for initialization
    void Start () {
        Rfc2898DeriveBytes PBKDF2_hash = new Rfc2898DeriveBytes("qwerty", Encoding.ASCII.GetBytes("rm4fSDh0sofK"), 20000);
        HMACSHA256 HMACSHA256_hash = new HMACSHA256();
        //System.Text.Encoding.UTF8.GetString(bytes);
        string hPassword = Convert.ToBase64String(PBKDF2_hash.GetBytes(32));
        Debug.Log("Hash = " + hPassword);
        //Debug.Log("Password hash" + Encoding.ASCII.GetString(PBKDF2.GetBytes(256)));
        //PBKDF2.Salt = 


        /*string password = "Hello world";
        string hPassword = ComputeHash(password, new SHA256CryptoServiceProvider());
        Debug.Log("Hash from: " + password + " = " + hPassword);*/
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
