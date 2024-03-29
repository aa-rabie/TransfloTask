﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Transflo.Driver.Data;

#nullable disable

namespace Transflo.Driver.Data.Migrations
{
    [DbContext(typeof(DriverDbContext))]
    partial class DriverDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("Transflo.Driver.Models.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Drivers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "Sallie6@gmail.com",
                            FirstName = "Sallie",
                            LastName = "King",
                            Phone = "1-535-949-1723 x8565"
                        },
                        new
                        {
                            Id = 2,
                            Email = "Gustave.Harris36@yahoo.com",
                            FirstName = "Gustave",
                            LastName = "Harris",
                            Phone = "651-590-7488"
                        },
                        new
                        {
                            Id = 3,
                            Email = "Marjory_Stehr@yahoo.com",
                            FirstName = "Marjory",
                            LastName = "Stehr",
                            Phone = "1-457-605-8608"
                        },
                        new
                        {
                            Id = 4,
                            Email = "Verner_Kutch@gmail.com",
                            FirstName = "Verner",
                            LastName = "Kutch",
                            Phone = "1-764-905-4778 x47002"
                        },
                        new
                        {
                            Id = 5,
                            Email = "Marlee_Morar71@hotmail.com",
                            FirstName = "Marlee",
                            LastName = "Morar",
                            Phone = "947-264-9456"
                        },
                        new
                        {
                            Id = 6,
                            Email = "Douglas_Marquardt@gmail.com",
                            FirstName = "Douglas",
                            LastName = "Marquardt",
                            Phone = "882.458.4313"
                        },
                        new
                        {
                            Id = 7,
                            Email = "Russ28@hotmail.com",
                            FirstName = "Russ",
                            LastName = "Heller",
                            Phone = "201-689-6981 x097"
                        },
                        new
                        {
                            Id = 8,
                            Email = "Stan_OKon75@yahoo.com",
                            FirstName = "Stan",
                            LastName = "O'Kon",
                            Phone = "(432) 991-3378"
                        },
                        new
                        {
                            Id = 9,
                            Email = "Dawn_Friesen@yahoo.com",
                            FirstName = "Dawn",
                            LastName = "Friesen",
                            Phone = "455.219.8422"
                        },
                        new
                        {
                            Id = 10,
                            Email = "Lela3@gmail.com",
                            FirstName = "Lela",
                            LastName = "Borer",
                            Phone = "1-271-740-2912"
                        },
                        new
                        {
                            Id = 11,
                            Email = "Clementine2@hotmail.com",
                            FirstName = "Clementine",
                            LastName = "Armstrong",
                            Phone = "797-330-2423"
                        },
                        new
                        {
                            Id = 12,
                            Email = "Arielle_DuBuque81@hotmail.com",
                            FirstName = "Arielle",
                            LastName = "DuBuque",
                            Phone = "1-265-554-5755 x6269"
                        },
                        new
                        {
                            Id = 13,
                            Email = "Aurelio_Legros@gmail.com",
                            FirstName = "Aurelio",
                            LastName = "Legros",
                            Phone = "940-796-9058"
                        },
                        new
                        {
                            Id = 14,
                            Email = "Dell_Kassulke38@gmail.com",
                            FirstName = "Dell",
                            LastName = "Kassulke",
                            Phone = "(655) 200-5846"
                        },
                        new
                        {
                            Id = 15,
                            Email = "Pedro.Ortiz@yahoo.com",
                            FirstName = "Pedro",
                            LastName = "Ortiz",
                            Phone = "472-550-4296 x2266"
                        },
                        new
                        {
                            Id = 16,
                            Email = "Alvina.Jacobi@yahoo.com",
                            FirstName = "Alvina",
                            LastName = "Jacobi",
                            Phone = "953.274.8208 x9133"
                        },
                        new
                        {
                            Id = 17,
                            Email = "Jazmin_Walsh@gmail.com",
                            FirstName = "Jazmin",
                            LastName = "Walsh",
                            Phone = "1-499-746-8249"
                        },
                        new
                        {
                            Id = 18,
                            Email = "Milton.Gutmann51@yahoo.com",
                            FirstName = "Milton",
                            LastName = "Gutmann",
                            Phone = "1-582-460-0430 x2113"
                        },
                        new
                        {
                            Id = 19,
                            Email = "Braden.Kutch@hotmail.com",
                            FirstName = "Braden",
                            LastName = "Kutch",
                            Phone = "982-968-3797 x6678"
                        },
                        new
                        {
                            Id = 20,
                            Email = "Hal_Ferry@yahoo.com",
                            FirstName = "Hal",
                            LastName = "Ferry",
                            Phone = "481.786.7299 x084"
                        },
                        new
                        {
                            Id = 21,
                            Email = "Willow56@gmail.com",
                            FirstName = "Willow",
                            LastName = "Schulist",
                            Phone = "307-562-8403"
                        },
                        new
                        {
                            Id = 22,
                            Email = "Jaquan.Legros@yahoo.com",
                            FirstName = "Jaquan",
                            LastName = "Legros",
                            Phone = "(421) 998-3872 x704"
                        },
                        new
                        {
                            Id = 23,
                            Email = "Janelle54@hotmail.com",
                            FirstName = "Janelle",
                            LastName = "Jacobi",
                            Phone = "598-296-8027 x616"
                        },
                        new
                        {
                            Id = 24,
                            Email = "Antwan44@yahoo.com",
                            FirstName = "Antwan",
                            LastName = "Johnson",
                            Phone = "1-423-473-6308"
                        },
                        new
                        {
                            Id = 25,
                            Email = "Caitlyn_Yost22@hotmail.com",
                            FirstName = "Caitlyn",
                            LastName = "Yost",
                            Phone = "1-822-717-5978 x8736"
                        },
                        new
                        {
                            Id = 26,
                            Email = "Asia.OKeefe@gmail.com",
                            FirstName = "Asia",
                            LastName = "O'Keefe",
                            Phone = "899-555-2958 x8716"
                        },
                        new
                        {
                            Id = 27,
                            Email = "Albina.McLaughlin@yahoo.com",
                            FirstName = "Albina",
                            LastName = "McLaughlin",
                            Phone = "709-536-9744 x77127"
                        },
                        new
                        {
                            Id = 28,
                            Email = "Geovany.Kunde27@gmail.com",
                            FirstName = "Geovany",
                            LastName = "Kunde",
                            Phone = "367-830-1143 x075"
                        },
                        new
                        {
                            Id = 29,
                            Email = "Keyon_Christiansen@hotmail.com",
                            FirstName = "Keyon",
                            LastName = "Christiansen",
                            Phone = "739-634-8046"
                        },
                        new
                        {
                            Id = 30,
                            Email = "Joannie_Leffler45@hotmail.com",
                            FirstName = "Joannie",
                            LastName = "Leffler",
                            Phone = "554.339.3387 x46911"
                        },
                        new
                        {
                            Id = 31,
                            Email = "Delphine.Olson@hotmail.com",
                            FirstName = "Delphine",
                            LastName = "Olson",
                            Phone = "428-522-6304"
                        },
                        new
                        {
                            Id = 32,
                            Email = "Kenna49@yahoo.com",
                            FirstName = "Kenna",
                            LastName = "Koepp",
                            Phone = "348-442-6229 x3273"
                        },
                        new
                        {
                            Id = 33,
                            Email = "Saul_Marks@gmail.com",
                            FirstName = "Saul",
                            LastName = "Marks",
                            Phone = "881.437.1622"
                        },
                        new
                        {
                            Id = 34,
                            Email = "Carlee.Rau@gmail.com",
                            FirstName = "Carlee",
                            LastName = "Rau",
                            Phone = "1-410-747-5154 x44184"
                        },
                        new
                        {
                            Id = 35,
                            Email = "Laura8@yahoo.com",
                            FirstName = "Laura",
                            LastName = "Bauch",
                            Phone = "633.577.6676"
                        },
                        new
                        {
                            Id = 36,
                            Email = "Emmitt61@hotmail.com",
                            FirstName = "Emmitt",
                            LastName = "Runte",
                            Phone = "564.233.5865"
                        },
                        new
                        {
                            Id = 37,
                            Email = "Maya_Ebert@yahoo.com",
                            FirstName = "Maya",
                            LastName = "Ebert",
                            Phone = "669-689-5961"
                        },
                        new
                        {
                            Id = 38,
                            Email = "Sally_Nicolas@hotmail.com",
                            FirstName = "Sally",
                            LastName = "Nicolas",
                            Phone = "1-925-495-2458 x76795"
                        },
                        new
                        {
                            Id = 39,
                            Email = "Eli_Gusikowski19@yahoo.com",
                            FirstName = "Eli",
                            LastName = "Gusikowski",
                            Phone = "(255) 420-6696"
                        },
                        new
                        {
                            Id = 40,
                            Email = "Maia.Treutel77@gmail.com",
                            FirstName = "Maia",
                            LastName = "Treutel",
                            Phone = "439.925.2366"
                        },
                        new
                        {
                            Id = 41,
                            Email = "Garland51@hotmail.com",
                            FirstName = "Garland",
                            LastName = "Watsica",
                            Phone = "359.545.2089 x0817"
                        },
                        new
                        {
                            Id = 42,
                            Email = "Halie_Spinka@yahoo.com",
                            FirstName = "Halie",
                            LastName = "Spinka",
                            Phone = "1-827-845-8691"
                        },
                        new
                        {
                            Id = 43,
                            Email = "Magnolia7@yahoo.com",
                            FirstName = "Magnolia",
                            LastName = "Marquardt",
                            Phone = "(226) 546-0418 x803"
                        },
                        new
                        {
                            Id = 44,
                            Email = "Tyreek91@gmail.com",
                            FirstName = "Tyreek",
                            LastName = "Goyette",
                            Phone = "990.258.0766 x803"
                        },
                        new
                        {
                            Id = 45,
                            Email = "Mathew.Daugherty@gmail.com",
                            FirstName = "Mathew",
                            LastName = "Daugherty",
                            Phone = "583-762-6368 x184"
                        },
                        new
                        {
                            Id = 46,
                            Email = "Joelle_Kuhlman@gmail.com",
                            FirstName = "Joelle",
                            LastName = "Kuhlman",
                            Phone = "1-721-948-0992 x972"
                        },
                        new
                        {
                            Id = 47,
                            Email = "Lexus65@gmail.com",
                            FirstName = "Lexus",
                            LastName = "Upton",
                            Phone = "1-677-829-2985 x84204"
                        },
                        new
                        {
                            Id = 48,
                            Email = "Teresa.Erdman40@gmail.com",
                            FirstName = "Teresa",
                            LastName = "Erdman",
                            Phone = "974-393-7651 x504"
                        },
                        new
                        {
                            Id = 49,
                            Email = "Izabella.Heller72@gmail.com",
                            FirstName = "Izabella",
                            LastName = "Heller",
                            Phone = "894.645.5313"
                        },
                        new
                        {
                            Id = 50,
                            Email = "Eldred_Zboncak@yahoo.com",
                            FirstName = "Eldred",
                            LastName = "Zboncak",
                            Phone = "468-751-1841"
                        },
                        new
                        {
                            Id = 51,
                            Email = "Lauryn_Quitzon37@hotmail.com",
                            FirstName = "Lauryn",
                            LastName = "Quitzon",
                            Phone = "(972) 509-0856"
                        },
                        new
                        {
                            Id = 52,
                            Email = "Kaylie.Kub47@hotmail.com",
                            FirstName = "Kaylie",
                            LastName = "Kub",
                            Phone = "1-933-792-5147 x00330"
                        },
                        new
                        {
                            Id = 53,
                            Email = "Dillan.Gutkowski69@hotmail.com",
                            FirstName = "Dillan",
                            LastName = "Gutkowski",
                            Phone = "1-411-966-8103"
                        },
                        new
                        {
                            Id = 54,
                            Email = "Maegan86@gmail.com",
                            FirstName = "Maegan",
                            LastName = "Vandervort",
                            Phone = "(380) 764-3896"
                        },
                        new
                        {
                            Id = 55,
                            Email = "Jovanny_Lebsack13@yahoo.com",
                            FirstName = "Jovanny",
                            LastName = "Lebsack",
                            Phone = "1-951-340-8281 x159"
                        },
                        new
                        {
                            Id = 56,
                            Email = "Cleora1@hotmail.com",
                            FirstName = "Cleora",
                            LastName = "Boehm",
                            Phone = "1-433-473-3482 x84417"
                        },
                        new
                        {
                            Id = 57,
                            Email = "Jeanette10@yahoo.com",
                            FirstName = "Jeanette",
                            LastName = "Rath",
                            Phone = "453-944-6135 x26523"
                        },
                        new
                        {
                            Id = 58,
                            Email = "Dejah89@gmail.com",
                            FirstName = "Dejah",
                            LastName = "Littel",
                            Phone = "237-508-1427 x029"
                        },
                        new
                        {
                            Id = 59,
                            Email = "Helena34@hotmail.com",
                            FirstName = "Helena",
                            LastName = "Crist",
                            Phone = "950.576.4279 x896"
                        },
                        new
                        {
                            Id = 60,
                            Email = "Jamarcus.Hickle@hotmail.com",
                            FirstName = "Jamarcus",
                            LastName = "Hickle",
                            Phone = "953.338.1042"
                        },
                        new
                        {
                            Id = 61,
                            Email = "Myrtice.Abshire@hotmail.com",
                            FirstName = "Myrtice",
                            LastName = "Abshire",
                            Phone = "433.944.0680 x9334"
                        },
                        new
                        {
                            Id = 62,
                            Email = "Donny.Hudson@yahoo.com",
                            FirstName = "Donny",
                            LastName = "Hudson",
                            Phone = "1-697-922-5503 x13784"
                        },
                        new
                        {
                            Id = 63,
                            Email = "Chad97@hotmail.com",
                            FirstName = "Chad",
                            LastName = "Mayert",
                            Phone = "895-334-6072 x27536"
                        },
                        new
                        {
                            Id = 64,
                            Email = "Violette.Kris94@yahoo.com",
                            FirstName = "Violette",
                            LastName = "Kris",
                            Phone = "(748) 204-3003"
                        },
                        new
                        {
                            Id = 65,
                            Email = "Claudie_Schoen@yahoo.com",
                            FirstName = "Claudie",
                            LastName = "Schoen",
                            Phone = "253.270.1756 x569"
                        },
                        new
                        {
                            Id = 66,
                            Email = "Tristin37@gmail.com",
                            FirstName = "Tristin",
                            LastName = "Dickinson",
                            Phone = "(537) 594-0257"
                        },
                        new
                        {
                            Id = 67,
                            Email = "Dewitt35@yahoo.com",
                            FirstName = "Dewitt",
                            LastName = "Corkery",
                            Phone = "1-481-783-6860 x5720"
                        },
                        new
                        {
                            Id = 68,
                            Email = "Lou.McCullough44@gmail.com",
                            FirstName = "Lou",
                            LastName = "McCullough",
                            Phone = "213.283.5752 x390"
                        },
                        new
                        {
                            Id = 69,
                            Email = "Princess_Erdman@yahoo.com",
                            FirstName = "Princess",
                            LastName = "Erdman",
                            Phone = "895-488-8945 x5267"
                        },
                        new
                        {
                            Id = 70,
                            Email = "Emmitt_Flatley@gmail.com",
                            FirstName = "Emmitt",
                            LastName = "Flatley",
                            Phone = "778.729.5240 x2140"
                        },
                        new
                        {
                            Id = 71,
                            Email = "Isidro_Schimmel@gmail.com",
                            FirstName = "Isidro",
                            LastName = "Schimmel",
                            Phone = "658.847.7132 x43518"
                        },
                        new
                        {
                            Id = 72,
                            Email = "Leo.Paucek@hotmail.com",
                            FirstName = "Leo",
                            LastName = "Paucek",
                            Phone = "885-985-1420 x454"
                        },
                        new
                        {
                            Id = 73,
                            Email = "Ari.Corwin8@yahoo.com",
                            FirstName = "Ari",
                            LastName = "Corwin",
                            Phone = "862-683-5664 x16775"
                        },
                        new
                        {
                            Id = 74,
                            Email = "Dee28@gmail.com",
                            FirstName = "Dee",
                            LastName = "Senger",
                            Phone = "1-838-972-5604 x5936"
                        },
                        new
                        {
                            Id = 75,
                            Email = "Olin55@hotmail.com",
                            FirstName = "Olin",
                            LastName = "Mann",
                            Phone = "(287) 827-9213 x0644"
                        },
                        new
                        {
                            Id = 76,
                            Email = "Alexander.Howell@hotmail.com",
                            FirstName = "Alexander",
                            LastName = "Howell",
                            Phone = "314-346-1466 x780"
                        },
                        new
                        {
                            Id = 77,
                            Email = "Rachelle.Koch83@gmail.com",
                            FirstName = "Rachelle",
                            LastName = "Koch",
                            Phone = "(442) 410-0294"
                        },
                        new
                        {
                            Id = 78,
                            Email = "Murray36@hotmail.com",
                            FirstName = "Murray",
                            LastName = "Doyle",
                            Phone = "(371) 891-8156 x9451"
                        },
                        new
                        {
                            Id = 79,
                            Email = "Peggie_Senger70@hotmail.com",
                            FirstName = "Peggie",
                            LastName = "Senger",
                            Phone = "1-221-708-5370"
                        },
                        new
                        {
                            Id = 80,
                            Email = "Zander.Leuschke@yahoo.com",
                            FirstName = "Zander",
                            LastName = "Leuschke",
                            Phone = "591-394-4705 x24698"
                        },
                        new
                        {
                            Id = 81,
                            Email = "Ena.Greenholt64@hotmail.com",
                            FirstName = "Ena",
                            LastName = "Greenholt",
                            Phone = "802-507-1381 x070"
                        },
                        new
                        {
                            Id = 82,
                            Email = "Irwin28@yahoo.com",
                            FirstName = "Irwin",
                            LastName = "Champlin",
                            Phone = "589.235.5211"
                        },
                        new
                        {
                            Id = 83,
                            Email = "Brandon24@gmail.com",
                            FirstName = "Brandon",
                            LastName = "Cronin",
                            Phone = "743-787-1856"
                        },
                        new
                        {
                            Id = 84,
                            Email = "Nadia.Mills69@hotmail.com",
                            FirstName = "Nadia",
                            LastName = "Mills",
                            Phone = "(595) 310-4691"
                        },
                        new
                        {
                            Id = 85,
                            Email = "Rodrick.Mante41@gmail.com",
                            FirstName = "Rodrick",
                            LastName = "Mante",
                            Phone = "1-704-588-6456 x219"
                        },
                        new
                        {
                            Id = 86,
                            Email = "Al.Murazik26@yahoo.com",
                            FirstName = "Al",
                            LastName = "Murazik",
                            Phone = "393-661-1056 x84033"
                        },
                        new
                        {
                            Id = 87,
                            Email = "Demetris_Herzog74@yahoo.com",
                            FirstName = "Demetris",
                            LastName = "Herzog",
                            Phone = "207-711-7453"
                        },
                        new
                        {
                            Id = 88,
                            Email = "Nelle42@gmail.com",
                            FirstName = "Nelle",
                            LastName = "Dickens",
                            Phone = "(371) 241-1162"
                        },
                        new
                        {
                            Id = 89,
                            Email = "Kristina.Raynor23@yahoo.com",
                            FirstName = "Kristina",
                            LastName = "Raynor",
                            Phone = "(924) 350-4497 x08220"
                        },
                        new
                        {
                            Id = 90,
                            Email = "Moshe83@yahoo.com",
                            FirstName = "Moshe",
                            LastName = "Feest",
                            Phone = "1-632-844-6372 x786"
                        },
                        new
                        {
                            Id = 91,
                            Email = "Parker.Konopelski@yahoo.com",
                            FirstName = "Parker",
                            LastName = "Konopelski",
                            Phone = "750.303.3574 x0959"
                        },
                        new
                        {
                            Id = 92,
                            Email = "Rafael76@hotmail.com",
                            FirstName = "Rafael",
                            LastName = "Conroy",
                            Phone = "(538) 246-2444"
                        },
                        new
                        {
                            Id = 93,
                            Email = "Kavon.DuBuque87@hotmail.com",
                            FirstName = "Kavon",
                            LastName = "DuBuque",
                            Phone = "(709) 949-3015 x6019"
                        },
                        new
                        {
                            Id = 94,
                            Email = "Carmen_Schulist80@gmail.com",
                            FirstName = "Carmen",
                            LastName = "Schulist",
                            Phone = "649-926-9870 x30034"
                        },
                        new
                        {
                            Id = 95,
                            Email = "Dejuan63@hotmail.com",
                            FirstName = "Dejuan",
                            LastName = "Deckow",
                            Phone = "553-665-7910"
                        },
                        new
                        {
                            Id = 96,
                            Email = "Jerrod.Jacobs84@gmail.com",
                            FirstName = "Jerrod",
                            LastName = "Jacobs",
                            Phone = "391.215.8172 x26658"
                        },
                        new
                        {
                            Id = 97,
                            Email = "Anita.Okuneva24@gmail.com",
                            FirstName = "Anita",
                            LastName = "Okuneva",
                            Phone = "385.279.2914 x58877"
                        },
                        new
                        {
                            Id = 98,
                            Email = "Albertha_Schinner80@yahoo.com",
                            FirstName = "Albertha",
                            LastName = "Schinner",
                            Phone = "1-412-462-6214 x002"
                        },
                        new
                        {
                            Id = 99,
                            Email = "Franco.Ruecker@gmail.com",
                            FirstName = "Franco",
                            LastName = "Ruecker",
                            Phone = "1-938-426-5785 x12991"
                        },
                        new
                        {
                            Id = 100,
                            Email = "Malcolm_Brakus28@yahoo.com",
                            FirstName = "Malcolm",
                            LastName = "Brakus",
                            Phone = "282.492.0727 x859"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
