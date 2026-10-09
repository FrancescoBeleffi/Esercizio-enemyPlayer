using BlaisePascal.EsercizioEnemy.Domain;

class Program()
{
    public static void Main()
    {
        Player player = new Player("Player");
        try
        {
            player.AddGold(-500);
        }
        catch (Exception ex) { Console.WriteLine(ex.Message); }
        try
        {
            player.Heal(-100);
        }
        catch (Exception ex) { Console.WriteLine(ex.Message); }
       
        try
        {
            player.TakeDamage(-1);
        }
        catch (Exception ex) { Console.WriteLine(ex.Message); }
    }
}
