using System.Reflection;

public class Alphabet 
{
    public static string AishaAlphabet()
    {
        Dictionary<char, string> Nana = new Dictionary<char, string>();
        Nana['A'] = "Argon";
        Nana['B'] = "Boron";
        Nana['C'] = "Carbon";
        Nana['D'] = "Density"; 
        Nana['E'] = "Enzymes";
        Nana['F'] = "Florine";
        Nana['G'] = "Glycerol";
        Nana['H'] = "Helium"; 
        Nana['I'] = "Iodine";
        Nana['J'] = "Joules";
        Nana['K'] = "Kalium";
        Nana['L'] = "Lithium";
        Nana['M'] = "Maganese";
        Nana['N'] = "Nitrogen";
        Nana['O'] = "Oxygen";
        Nana['P'] = "Phosphorus";
        Nana['Q'] = "Quantom";
        Nana['R'] = "Randium";
        Nana['S'] = "Silicon";
        Nana['T'] = "Titanium";
        Nana['U'] = "Uranium";
        Nana['V'] = "Vanadium";
        Nana['W'] = "Wave";
        Nana['X'] = "Xylem";
        Nana['Y'] = "Yeast";
        Nana['Z'] = "Zinc";
        int i = 1;
        foreach(var Aish in Nana)
        {
            Console.WriteLine($"{i}. {Aish.Key}: {Aish.Value}");
            i++;
            
        } 
        return"Maisha";
    }





}