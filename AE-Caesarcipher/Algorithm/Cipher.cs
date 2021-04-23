namespace AE_Caesarcipher.Algorithm
{
    /// <summary>
    /// Eine Klasse die Informationen über unsere Cipher speichert.
    /// </summary>
    public class Cipher
    {
        public string Message { get; private set; }
        public bool IsEncrypted { get; private set; }

        public Cipher(string Message, bool IsEncrypted)
        {
            this.Message = Message;
            this.IsEncrypted = IsEncrypted;
        }

        public override string ToString()
        {
            return $"Cipher:\r\nIsEncrypted: {IsEncrypted}\r\nText: {Message}";
        }
    }
}
