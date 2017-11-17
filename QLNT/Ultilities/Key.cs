using System;

public enum Quyen
{
    Admin = 0,
    GiaoVu = 1,
    GiaoVien = 2,
    NhaBep = 3
}

public class KeyHandle
{
    public static string GetKeyFromCombobox(string value)
    {
        if (value != null)
        {
            var code = value.Split(new[] { "Value = " }, StringSplitOptions.None)[1];
            code = code.Substring(0, code.Length - 2);
            return code;
        }
        return null;
    }
}