using System.Text;

namespace AE_Caesarcipher.Algorithm
{
    /// <summary>
    /// Eine statische Klasse zum erstellen von Caeser-Verschlüsselungen.
    /// </summary>
    public static class Caesarcipher
    {
        /// <summary>
        /// Das Alphabet, ein Caesar-Alphabet wird anhand diesem Alphabet erstellt, erlaubt für eine direkte gegenüberstellung.
        /// </summary>
        public static string Alphabet { get; } = "ABCDEFGHIJKLMNOPQRSTUVWXYZ" + "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower();

        /// <summary>
        /// Entschlüsselt eine Cipher mit einem angegebenen Key.
        /// </summary>
        /// <param name="Target">Eine Cipher die entschlüsselt werden soll.</param>
        /// <param name="Key">Der Key mit dem das Caeser-Alphabet erstllt wird.</param>
        /// <returns>Die verschlüsselte Cipher</returns>
        public static Cipher Decipher(Cipher Target, int Key)
        {
            if (!Target.IsEncrypted)
                return Target;

            var CeaserAlphabet = GetCeaserAlphabet(Key);

            StringBuilder strb = new StringBuilder();

            foreach (var c in Target.Message)
            {
                var index = CeaserAlphabet.IndexOf(c);

                if (index == -1)
                {
                    strb.Append(c);
                    continue;
                }

                strb.Append(Alphabet[index].ToString());
            }

            return new Cipher(strb.ToString(), false);
        }

        /// <summary>
        /// Verschlüsselt eine Cipher mit einem angegebenen Key.
        /// </summary>
        /// <param name="Target">Eine Cipher die verschlüsselt werden soll.</param>
        /// <param name="Key">Der Key mit dem das Caeser-Alphabet erstllt wird.</param>
        /// <returns>Die verschlüsselte Cipher.</returns>
        public static Cipher Cipher(Cipher Target, int Key)
        {
            if (Target.IsEncrypted)
                return Target;

            var CeaserAlphabet = GetCeaserAlphabet(Key);

            StringBuilder strb = new StringBuilder();

            foreach (var c in Target.Message)
            {
                var index = Alphabet.IndexOf(c);

                if (index == -1)
                {
                    strb.Append(c);
                    continue;
                }

                strb.Append(CeaserAlphabet[index].ToString());
            }

            return new Cipher(strb.ToString(), true);
        }

        /// <summary>
        /// Erstellt ein Caeser-Aphabet mit einem angegebenen Key.
        /// Die Buchstaben werden also um den Wert des Key nach rechts geschoben.
        /// </summary>
        /// <param name="Key">Der Key mit dem die Buchstaben verschoben werden im Alphabet.</param>
        /// <returns>Das Caeser-Alphabet</returns>
        public static string GetCeaserAlphabet(int Key)
        {
            var size = Alphabet.Length;
            var newalphabet = new char[size];
            for (int i = 0; i < size; i++)
            {
                newalphabet[i] = Alphabet[(i + Key) % size];
            }
            return new string(newalphabet);
        }
    }
}
