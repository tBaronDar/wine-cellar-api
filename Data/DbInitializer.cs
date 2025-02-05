using WineCellarAPI.Models;

namespace WineCellarAPI.Data;

public static class DbInitializer
{

    public static void Initialize(WineCellarContext context)
    {

        if (context.Wines.Any() && context.Aromas.Any() && context.GrapeVarieties.Any())
        {
            return;
        }
        //if no tables exist

        GrapeVariety Limnio = new GrapeVariety { Name = "Limnio", CountryOfOrigin = "Greece" };
        GrapeVariety Sabatiano = new GrapeVariety { Name = "Savatiano", CountryOfOrigin = "Greece" };
        GrapeVariety PinotNoir = new GrapeVariety { Name = "Pinot Noir", CountryOfOrigin = "France" };
        GrapeVariety Negoska = new GrapeVariety { Name = "Negoska", CountryOfOrigin = "Greece" };
        GrapeVariety SauvignonBlanc = new GrapeVariety { Name = "Sauvignon Blanc", CountryOfOrigin = "France" };
        GrapeVariety Syrah = new GrapeVariety { Name = "Syrah", CountryOfOrigin = "France" };
        GrapeVariety Asirtiko = new GrapeVariety { Name = "Asirtiko", CountryOfOrigin = "Greece" };
        GrapeVariety Agiorgitiko = new GrapeVariety { Name = "Agiorgitiko", CountryOfOrigin = "Greece" };
        GrapeVariety GrenacheRouge = new GrapeVariety { Name = "Grenache Rouge", CountryOfOrigin = "France" };


        Aroma Chocolate = new Aroma { Name = "Chocolate" };
        Aroma Vanilla = new Aroma { Name = "Vanilla" };
        Aroma Leather = new Aroma { Name = "Leather" };
        Aroma TropicalFruits = new Aroma { Name = "Tropical Fruits" };
        Aroma Lemon = new Aroma { Name = "Lemon" };
        Aroma Cherry = new Aroma { Name = "Cherry" };
        Aroma Berries = new Aroma { Name = "Berries" };
        Aroma Grapefruit = new Aroma { Name = "Grapefruit" };
        Aroma CitrusFruits = new Aroma { Name = "Citrus Fruits" };
        Aroma WhiteFlowers = new Aroma { Name = "White Flowers" };

        Wine[] wines = new Wine[]{
             new Wine
             {
                Name="Emphasis",
                Maker="Ktima Pavlidi",
                Aromas= new List<Aroma>{Cherry,Berries,},
                Color=WineColor.Red,
                GrapeVarieties= new List<GrapeVariety>{Syrah},
                Description="Βαθυκόκκινο χρώμα με έντονα ιώδεις ανταύγειες. Πολύπλοκη αρωματική παλέτα όπου τα πρωτογενή αρώματα της ποικιλίας (νότες από μικρά κόκκινα φρούτα όπως κεράσι, βατόμουρο) συνδυάζονται με βοτανικούς χαρακτήρες (βασιλικός, θυμάρι) και νότες από βανίλια και καφέ, αποτέλεσμα της πολύμηνης παλαίωσης σε δρύινα βαρέλια. Πλούσιο και ισορροπημένο στόμα, λιπαρό, με ρωμαλέα δομή που του προσδίδει μεγάλη αντοχή στο χρόνο. Θελκτική και μακράς διάρκειας επίγευση που αναδεικνύει τους γευστικούς χαρακτήρες του οίνου.Ιδανικά σερβίρεται στους 17-18 °C μαζί με σκληρά καπνιστά τυριά, κρεατικά μαγειρεμένα με πικάντικες σάλτσες και κυνήγι. Είναι ένας οίνος με μεγάλο δυναμικό παλαίωσης. Συνιστάται η χρήση καράφας."
        },
        new Wine
             {
                Maker="Ktima Vivlia Hora",
                Aromas= new List<Aroma>{Lemon,TropicalFruits, Grapefruit},
                Color=WineColor.White,
                GrapeVarieties= new List<GrapeVariety>{SauvignonBlanc,Asirtiko},
                Description="To λευκό του Κτήματος Βιβλία Χώρα αποτελεί ένα αρωματικό και φρέσκο κρασί, φτιαγμένο για όλες τις στιγμές. Παράγεται από το πάντρεµα της αρωματικής ποικιλίας Sauvignon Blanc και του πληθωρικού Ασύρτικου. Το χρώμα του, είναι απαλό πρασινοκίτρινο, µε έντονη διαύγεια. Έντονα αρώματα τροπικών φρούτων, γκρέιπφρουτ, εναλλάσσονται µε νότες εσπεριδοειδών &  λεμονιού. Σερβίρεται στους 10οC και προτείνεται να καταναλωθεί σε 2 χρόνια. Πίνεται σκέτο ως απεριτίφ, ενώ μπορεί να συνοδεύσει εξαιρετικά πλατό τυριών, ριζοτο και θαλασσινά."
        },
        new Wine
            {
                Name="Idylle D' Achinos",
                Maker="La Tour Melas",
                Aromas= new List<Aroma>{CitrusFruits,WhiteFlowers},
                Color=WineColor.Rosé,
                GrapeVarieties= new List<GrapeVariety>{Syrah,Agiorgitiko,GrenacheRouge},
                Description="Το \"Idylle D' Achinos\"  αποτελεί μία από τις καινούργιες δημιουργίες του οινοποιείου La Tour Melas. Από την όψη σε «ταξιδεύει» στην Προβηγκία, χάρη στο σαγηνευτικό σομόν χρώμα.Στη μύτη, κυριαρχούν κόκκινα φρούτα, κόκκινο μήλο, εσπεριδοειδή όπως το σαγκουίνι, φλούδες πορτοκαλιού και λευκά άνθη. Στο στόμα έχει σώμα, δροσιστική οξύτητα και γευστική επίγευση. Ταιριάζει με σολωμό, θαλασσινά και σαλάτες εποχής."
            }
          };

        context.Wines.AddRange(wines);
        context.SaveChanges();
    }
}