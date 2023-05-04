using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Transflo.Driver.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Phone = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 1, "Sallie6@gmail.com", "Sallie", "King", "1-535-949-1723 x8565" },
                    { 2, "Gustave.Harris36@yahoo.com", "Gustave", "Harris", "651-590-7488" },
                    { 3, "Marjory_Stehr@yahoo.com", "Marjory", "Stehr", "1-457-605-8608" },
                    { 4, "Verner_Kutch@gmail.com", "Verner", "Kutch", "1-764-905-4778 x47002" },
                    { 5, "Marlee_Morar71@hotmail.com", "Marlee", "Morar", "947-264-9456" },
                    { 6, "Douglas_Marquardt@gmail.com", "Douglas", "Marquardt", "882.458.4313" },
                    { 7, "Russ28@hotmail.com", "Russ", "Heller", "201-689-6981 x097" },
                    { 8, "Stan_OKon75@yahoo.com", "Stan", "O'Kon", "(432) 991-3378" },
                    { 9, "Dawn_Friesen@yahoo.com", "Dawn", "Friesen", "455.219.8422" },
                    { 10, "Lela3@gmail.com", "Lela", "Borer", "1-271-740-2912" },
                    { 11, "Clementine2@hotmail.com", "Clementine", "Armstrong", "797-330-2423" },
                    { 12, "Arielle_DuBuque81@hotmail.com", "Arielle", "DuBuque", "1-265-554-5755 x6269" },
                    { 13, "Aurelio_Legros@gmail.com", "Aurelio", "Legros", "940-796-9058" },
                    { 14, "Dell_Kassulke38@gmail.com", "Dell", "Kassulke", "(655) 200-5846" },
                    { 15, "Pedro.Ortiz@yahoo.com", "Pedro", "Ortiz", "472-550-4296 x2266" },
                    { 16, "Alvina.Jacobi@yahoo.com", "Alvina", "Jacobi", "953.274.8208 x9133" },
                    { 17, "Jazmin_Walsh@gmail.com", "Jazmin", "Walsh", "1-499-746-8249" },
                    { 18, "Milton.Gutmann51@yahoo.com", "Milton", "Gutmann", "1-582-460-0430 x2113" },
                    { 19, "Braden.Kutch@hotmail.com", "Braden", "Kutch", "982-968-3797 x6678" },
                    { 20, "Hal_Ferry@yahoo.com", "Hal", "Ferry", "481.786.7299 x084" },
                    { 21, "Willow56@gmail.com", "Willow", "Schulist", "307-562-8403" },
                    { 22, "Jaquan.Legros@yahoo.com", "Jaquan", "Legros", "(421) 998-3872 x704" },
                    { 23, "Janelle54@hotmail.com", "Janelle", "Jacobi", "598-296-8027 x616" },
                    { 24, "Antwan44@yahoo.com", "Antwan", "Johnson", "1-423-473-6308" },
                    { 25, "Caitlyn_Yost22@hotmail.com", "Caitlyn", "Yost", "1-822-717-5978 x8736" },
                    { 26, "Asia.OKeefe@gmail.com", "Asia", "O'Keefe", "899-555-2958 x8716" },
                    { 27, "Albina.McLaughlin@yahoo.com", "Albina", "McLaughlin", "709-536-9744 x77127" },
                    { 28, "Geovany.Kunde27@gmail.com", "Geovany", "Kunde", "367-830-1143 x075" },
                    { 29, "Keyon_Christiansen@hotmail.com", "Keyon", "Christiansen", "739-634-8046" },
                    { 30, "Joannie_Leffler45@hotmail.com", "Joannie", "Leffler", "554.339.3387 x46911" },
                    { 31, "Delphine.Olson@hotmail.com", "Delphine", "Olson", "428-522-6304" },
                    { 32, "Kenna49@yahoo.com", "Kenna", "Koepp", "348-442-6229 x3273" },
                    { 33, "Saul_Marks@gmail.com", "Saul", "Marks", "881.437.1622" },
                    { 34, "Carlee.Rau@gmail.com", "Carlee", "Rau", "1-410-747-5154 x44184" },
                    { 35, "Laura8@yahoo.com", "Laura", "Bauch", "633.577.6676" },
                    { 36, "Emmitt61@hotmail.com", "Emmitt", "Runte", "564.233.5865" },
                    { 37, "Maya_Ebert@yahoo.com", "Maya", "Ebert", "669-689-5961" },
                    { 38, "Sally_Nicolas@hotmail.com", "Sally", "Nicolas", "1-925-495-2458 x76795" },
                    { 39, "Eli_Gusikowski19@yahoo.com", "Eli", "Gusikowski", "(255) 420-6696" },
                    { 40, "Maia.Treutel77@gmail.com", "Maia", "Treutel", "439.925.2366" },
                    { 41, "Garland51@hotmail.com", "Garland", "Watsica", "359.545.2089 x0817" },
                    { 42, "Halie_Spinka@yahoo.com", "Halie", "Spinka", "1-827-845-8691" },
                    { 43, "Magnolia7@yahoo.com", "Magnolia", "Marquardt", "(226) 546-0418 x803" },
                    { 44, "Tyreek91@gmail.com", "Tyreek", "Goyette", "990.258.0766 x803" },
                    { 45, "Mathew.Daugherty@gmail.com", "Mathew", "Daugherty", "583-762-6368 x184" },
                    { 46, "Joelle_Kuhlman@gmail.com", "Joelle", "Kuhlman", "1-721-948-0992 x972" },
                    { 47, "Lexus65@gmail.com", "Lexus", "Upton", "1-677-829-2985 x84204" },
                    { 48, "Teresa.Erdman40@gmail.com", "Teresa", "Erdman", "974-393-7651 x504" },
                    { 49, "Izabella.Heller72@gmail.com", "Izabella", "Heller", "894.645.5313" },
                    { 50, "Eldred_Zboncak@yahoo.com", "Eldred", "Zboncak", "468-751-1841" },
                    { 51, "Lauryn_Quitzon37@hotmail.com", "Lauryn", "Quitzon", "(972) 509-0856" },
                    { 52, "Kaylie.Kub47@hotmail.com", "Kaylie", "Kub", "1-933-792-5147 x00330" },
                    { 53, "Dillan.Gutkowski69@hotmail.com", "Dillan", "Gutkowski", "1-411-966-8103" },
                    { 54, "Maegan86@gmail.com", "Maegan", "Vandervort", "(380) 764-3896" },
                    { 55, "Jovanny_Lebsack13@yahoo.com", "Jovanny", "Lebsack", "1-951-340-8281 x159" },
                    { 56, "Cleora1@hotmail.com", "Cleora", "Boehm", "1-433-473-3482 x84417" },
                    { 57, "Jeanette10@yahoo.com", "Jeanette", "Rath", "453-944-6135 x26523" },
                    { 58, "Dejah89@gmail.com", "Dejah", "Littel", "237-508-1427 x029" },
                    { 59, "Helena34@hotmail.com", "Helena", "Crist", "950.576.4279 x896" },
                    { 60, "Jamarcus.Hickle@hotmail.com", "Jamarcus", "Hickle", "953.338.1042" },
                    { 61, "Myrtice.Abshire@hotmail.com", "Myrtice", "Abshire", "433.944.0680 x9334" },
                    { 62, "Donny.Hudson@yahoo.com", "Donny", "Hudson", "1-697-922-5503 x13784" },
                    { 63, "Chad97@hotmail.com", "Chad", "Mayert", "895-334-6072 x27536" },
                    { 64, "Violette.Kris94@yahoo.com", "Violette", "Kris", "(748) 204-3003" },
                    { 65, "Claudie_Schoen@yahoo.com", "Claudie", "Schoen", "253.270.1756 x569" },
                    { 66, "Tristin37@gmail.com", "Tristin", "Dickinson", "(537) 594-0257" },
                    { 67, "Dewitt35@yahoo.com", "Dewitt", "Corkery", "1-481-783-6860 x5720" },
                    { 68, "Lou.McCullough44@gmail.com", "Lou", "McCullough", "213.283.5752 x390" },
                    { 69, "Princess_Erdman@yahoo.com", "Princess", "Erdman", "895-488-8945 x5267" },
                    { 70, "Emmitt_Flatley@gmail.com", "Emmitt", "Flatley", "778.729.5240 x2140" },
                    { 71, "Isidro_Schimmel@gmail.com", "Isidro", "Schimmel", "658.847.7132 x43518" },
                    { 72, "Leo.Paucek@hotmail.com", "Leo", "Paucek", "885-985-1420 x454" },
                    { 73, "Ari.Corwin8@yahoo.com", "Ari", "Corwin", "862-683-5664 x16775" },
                    { 74, "Dee28@gmail.com", "Dee", "Senger", "1-838-972-5604 x5936" },
                    { 75, "Olin55@hotmail.com", "Olin", "Mann", "(287) 827-9213 x0644" },
                    { 76, "Alexander.Howell@hotmail.com", "Alexander", "Howell", "314-346-1466 x780" },
                    { 77, "Rachelle.Koch83@gmail.com", "Rachelle", "Koch", "(442) 410-0294" },
                    { 78, "Murray36@hotmail.com", "Murray", "Doyle", "(371) 891-8156 x9451" },
                    { 79, "Peggie_Senger70@hotmail.com", "Peggie", "Senger", "1-221-708-5370" },
                    { 80, "Zander.Leuschke@yahoo.com", "Zander", "Leuschke", "591-394-4705 x24698" },
                    { 81, "Ena.Greenholt64@hotmail.com", "Ena", "Greenholt", "802-507-1381 x070" },
                    { 82, "Irwin28@yahoo.com", "Irwin", "Champlin", "589.235.5211" },
                    { 83, "Brandon24@gmail.com", "Brandon", "Cronin", "743-787-1856" },
                    { 84, "Nadia.Mills69@hotmail.com", "Nadia", "Mills", "(595) 310-4691" },
                    { 85, "Rodrick.Mante41@gmail.com", "Rodrick", "Mante", "1-704-588-6456 x219" },
                    { 86, "Al.Murazik26@yahoo.com", "Al", "Murazik", "393-661-1056 x84033" },
                    { 87, "Demetris_Herzog74@yahoo.com", "Demetris", "Herzog", "207-711-7453" },
                    { 88, "Nelle42@gmail.com", "Nelle", "Dickens", "(371) 241-1162" },
                    { 89, "Kristina.Raynor23@yahoo.com", "Kristina", "Raynor", "(924) 350-4497 x08220" },
                    { 90, "Moshe83@yahoo.com", "Moshe", "Feest", "1-632-844-6372 x786" },
                    { 91, "Parker.Konopelski@yahoo.com", "Parker", "Konopelski", "750.303.3574 x0959" },
                    { 92, "Rafael76@hotmail.com", "Rafael", "Conroy", "(538) 246-2444" },
                    { 93, "Kavon.DuBuque87@hotmail.com", "Kavon", "DuBuque", "(709) 949-3015 x6019" },
                    { 94, "Carmen_Schulist80@gmail.com", "Carmen", "Schulist", "649-926-9870 x30034" },
                    { 95, "Dejuan63@hotmail.com", "Dejuan", "Deckow", "553-665-7910" },
                    { 96, "Jerrod.Jacobs84@gmail.com", "Jerrod", "Jacobs", "391.215.8172 x26658" },
                    { 97, "Anita.Okuneva24@gmail.com", "Anita", "Okuneva", "385.279.2914 x58877" },
                    { 98, "Albertha_Schinner80@yahoo.com", "Albertha", "Schinner", "1-412-462-6214 x002" },
                    { 99, "Franco.Ruecker@gmail.com", "Franco", "Ruecker", "1-938-426-5785 x12991" },
                    { 100, "Malcolm_Brakus28@yahoo.com", "Malcolm", "Brakus", "282.492.0727 x859" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drivers");
        }
    }
}
