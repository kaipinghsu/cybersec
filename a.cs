using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
public class Example
{
    public int Value;
    public string Text;
}

class Program
{
    static void Main()
    {
        Example obj = new Example { Value = 42, Text = "Hello" };

        // Serialize the object to a memory stream
        MemoryStream stream = new MemoryStream();
        BinaryFormatter formatter = new BinaryFormatter();
        formatter.Serialize(stream, obj);

        // Get the serialized byte array
        byte[] bytes = stream.ToArray();

        // Print the bytes in hex format
        Console.WriteLine(BitConverter.ToString(bytes).Replace("-", ""));
    }
}
