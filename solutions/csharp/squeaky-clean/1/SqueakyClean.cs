using System.Text;

public static class Identifier
{
    private static bool isGreekCharacter(char c) => (c >= 'α' && c <= 'ω');
    public static string Clean(string identifier)
    {
        StringBuilder sb = new StringBuilder();
        bool isAfterDash = false;
        
        foreach (char character in identifier)
        {
            sb.Append(character switch
                {
                    _ when isGreekCharacter(character) => default,
                    _ when isAfterDash => char.ToUpperInvariant(character),
                    _ when char.IsWhiteSpace(character) => '_',
                    _ when char.IsControl(character) => "CTRL",
                    _ when char.IsLetter(character) => character,
                    _ => default,
                });
                isAfterDash = character.Equals('-');
        }
        return sb.ToString();
    }
}
