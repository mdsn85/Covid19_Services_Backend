using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Covid19_Services_Backend.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CountryCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Slug = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    StatusOfCaseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.StatusOfCaseId);
                });

            migrationBuilder.CreateTable(
                name: "Cases",
                columns: table => new
                {
                    CaseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lat = table.Column<double>(type: "float", nullable: false),
                    Lon = table.Column<double>(type: "float", nullable: false),
                    CasesId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cases", x => x.CaseId);
                    table.ForeignKey(
                        name: "FK_Cases_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cases_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "StatusOfCaseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "CountryCode", "Name", "Slug" },
                values: new object[,]
                {
                    { 1, "EC", "Ecuador", "ecuador" },
                    { 159, "NZ", "New Zealand", "new-zealand" },
                    { 160, "PW", "Palau", "palau" },
                    { 161, "GL", "Greenland", "greenland" },
                    { 162, "PL", "Poland", "poland" },
                    { 163, "SY", "Syrian Arab Republic (Syria)", "syria" },
                    { 164, "ZW", "Zimbabwe", "zimbabwe" },
                    { 165, "AX", "ALA Aland Islands", "ala-aland-islands" },
                    { 166, "BV", "Bouvet Island", "bouvet-island" },
                    { 167, "CK", "Cook Islands", "cook-islands" },
                    { 168, "MK", "Macedonia, Republic of", "macedonia" },
                    { 169, "MY", "Malaysia", "malaysia" },
                    { 170, "HR", "Croatia", "croatia" },
                    { 171, "PA", "Panama", "panama" },
                    { 172, "BY", "Belarus", "belarus" },
                    { 173, "BO", "Bolivia", "bolivia" },
                    { 174, "GD", "Grenada", "grenada" },
                    { 175, "MV", "Maldives", "maldives" },
                    { 176, "NC", "New Caledonia", "new-caledonia" },
                    { 177, "VI", "Virgin Islands, US", "virgin-islands" },
                    { 178, "AT", "Austria", "austria" },
                    { 179, "CA", "Canada", "canada" },
                    { 180, "CN", "China", "china" },
                    { 181, "TW", "Taiwan, Republic of China", "taiwan" },
                    { 182, "BD", "Bangladesh", "bangladesh" },
                    { 183, "GT", "Guatemala", "guatemala" },
                    { 184, "NF", "Norfolk Island", "norfolk-island" },
                    { 185, "EE", "Estonia", "estonia" },
                    { 158, "ME", "Montenegro", "montenegro" },
                    { 186, "GF", "French Guiana", "french-guiana" },
                    { 157, "PS", "Palestinian Territory", "palestine" },
                    { 155, "TD", "Chad", "chad" },
                    { 128, "LV", "Latvia", "latvia" },
                    { 129, "EH", "Western Sahara", "western-sahara" },
                    { 130, "NO", "Norway", "norway" },
                    { 131, "SL", "Sierra Leone", "sierra-leone" },
                    { 132, "GA", "Gabon", "gabon" },
                    { 133, "MR", "Mauritania", "mauritania" },
                    { 134, "GH", "Ghana", "ghana" },
                    { 135, "GG", "Guernsey", "guernsey" },
                    { 136, "PY", "Paraguay", "paraguay" },
                    { 137, "SM", "San Marino", "san-marino" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "CountryCode", "Name", "Slug" },
                values: new object[,]
                {
                    { 138, "CR", "Costa Rica", "costa-rica" },
                    { 139, "TF", "French Southern Territories", "french-southern-territories" },
                    { 140, "CV", "Cape Verde", "cape-verde" },
                    { 141, "SA", "Saudi Arabia", "saudi-arabia" },
                    { 142, "VU", "Vanuatu", "vanuatu" },
                    { 143, "ID", "Indonesia", "indonesia" },
                    { 144, "JP", "Japan", "japan" },
                    { 145, "MW", "Malawi", "malawi" },
                    { 146, "DJ", "Djibouti", "djibouti" },
                    { 147, "VC", "Saint Vincent and Grenadines", "saint-vincent-and-the-grenadines" },
                    { 148, "SJ", "Svalbard and Jan Mayen Islands", "svalbard-and-jan-mayen-islands" },
                    { 149, "AQ", "Antarctica", "antarctica" },
                    { 150, "CU", "Cuba", "cuba" },
                    { 151, "GW", "Guinea-Bissau", "guinea-bissau" },
                    { 152, "LT", "Lithuania", "lithuania" },
                    { 153, "FM", "Micronesia, Federated States of", "micronesia" },
                    { 154, "MD", "Moldova", "moldova" },
                    { 156, "KM", "Comoros", "comoros" },
                    { 187, "RW", "Rwanda", "rwanda" },
                    { 188, "ZA", "South Africa", "south-africa" },
                    { 189, "BT", "Bhutan", "bhutan" },
                    { 222, "GN", "Guinea", "guinea" },
                    { 223, "TL", "Timor-Leste", "timor-leste" },
                    { 224, "BE", "Belgium", "belgium" },
                    { 225, "PT", "Portugal", "portugal" },
                    { 226, "SD", "Sudan", "sudan" },
                    { 227, "AN", "Netherlands Antilles", "netherlands-antilles" },
                    { 228, "SN", "Senegal", "senegal" },
                    { 229, "UA", "Ukraine", "ukraine" },
                    { 230, "GY", "Guyana", "guyana" },
                    { 231, "MZ", "Mozambique", "mozambique" },
                    { 232, "NG", "Nigeria", "nigeria" },
                    { 233, "LY", "Libya", "libya" },
                    { 234, "MU", "Mauritius", "mauritius" },
                    { 235, "PH", "Philippines", "philippines" },
                    { 236, "LC", "Saint Lucia", "saint-lucia" },
                    { 237, "AL", "Albania", "albania" },
                    { 238, "AD", "Andorra", "andorra" },
                    { 239, "KH", "Cambodia", "cambodia" },
                    { 240, "BI", "Burundi", "burundi" },
                    { 241, "CM", "Cameroon", "cameroon" },
                    { 242, "MH", "Marshall Islands", "marshall-islands" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "CountryCode", "Name", "Slug" },
                values: new object[,]
                {
                    { 243, "BR", "Brazil", "brazil" },
                    { 244, "MS", "Montserrat", "montserrat" },
                    { 245, "TH", "Thailand", "thailand" },
                    { 246, "IN", "India", "india" },
                    { 247, "IE", "Ireland", "ireland" },
                    { 248, "IT", "Italy", "italy" },
                    { 221, "GR", "Greece", "greece" },
                    { 220, "SK", "Slovakia", "slovakia" },
                    { 219, "PM", "Saint Pierre and Miquelon", "saint-pierre-and-miquelon" },
                    { 218, "QA", "Qatar", "qatar" },
                    { 190, "MN", "Mongolia", "mongolia" },
                    { 191, "HK", "Hong Kong, SAR China", "hong-kong-sar-china" },
                    { 192, "ML", "Mali", "mali" },
                    { 193, "PE", "Peru", "peru" },
                    { 194, "TG", "Togo", "togo" },
                    { 195, "BH", "Bahrain", "bahrain" },
                    { 196, "LR", "Liberia", "liberia" },
                    { 197, "LK", "Sri Lanka", "sri-lanka" },
                    { 198, "VN", "Viet Nam", "vietnam" },
                    { 199, "KP", "Korea (North)", "korea-north" },
                    { 200, "SH", "Saint Helena", "saint-helena" },
                    { 201, "ST", "Sao Tome and Principe", "sao-tome-and-principe" },
                    { 202, "ZM", "Zambia", "zambia" },
                    { 127, "KR", "Korea (South)", "korea-south" },
                    { 203, "LS", "Lesotho", "lesotho" },
                    { 205, "HT", "Haiti", "haiti" },
                    { 206, "BJ", "Benin", "benin" },
                    { 207, "FJ", "Fiji", "fiji" },
                    { 208, "FR", "France", "france" },
                    { 209, "IR", "Iran, Islamic Republic of", "iran" },
                    { 210, "KG", "Kyrgyzstan", "kyrgyzstan" },
                    { 211, "SZ", "Swaziland", "swaziland" },
                    { 212, "UZ", "Uzbekistan", "uzbekistan" },
                    { 213, "AG", "Antigua and Barbuda", "antigua-and-barbuda" },
                    { 214, "CG", "Congo (Brazzaville)", "congo-brazzaville" },
                    { 215, "GQ", "Equatorial Guinea", "equatorial-guinea" },
                    { 216, "YT", "Mayotte", "mayotte" },
                    { 217, "OM", "Oman", "oman" },
                    { 204, "US", "United States of America", "united-states" },
                    { 125, "GM", "Gambia", "gambia" },
                    { 126, "HU", "Hungary", "hungary" },
                    { 62, "BA", "Bosnia and Herzegovina", "bosnia-and-herzegovina" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "CountryCode", "Name", "Slug" },
                values: new object[,]
                {
                    { 35, "YE", "Yemen", "yemen" },
                    { 36, "MA", "Morocco", "morocco" },
                    { 37, "TO", "Tonga", "tonga" },
                    { 38, "AS", "American Samoa", "american-samoa" },
                    { 39, "BG", "Bulgaria", "bulgaria" },
                    { 40, "CC", "Cocos (Keeling) Islands", "cocos-keeling-islands" },
                    { 41, "BM", "Bermuda", "bermuda" },
                    { 42, "GU", "Guam", "guam" },
                    { 43, "SS", "South Sudan", "south-sudan" },
                    { 44, "FO", "Faroe Islands", "faroe-islands" },
                    { 45, "TJ", "Tajikistan", "tajikistan" },
                    { 46, "BW", "Botswana", "botswana" },
                    { 47, "KY", "Cayman Islands", "cayman-islands" },
                    { 48, "MM", "Myanmar", "myanmar" },
                    { 49, "GE", "Georgia", "georgia" },
                    { 50, "AM", "Armenia", "armenia" },
                    { 51, "CO", "Colombia", "colombia" },
                    { 52, "KW", "Kuwait", "kuwait" },
                    { 53, "MG", "Madagascar", "madagascar" },
                    { 54, "BB", "Barbados", "barbados" },
                    { 55, "IM", "Isle of Man", "isle-of-man" },
                    { 56, "KI", "Kiribati", "kiribati" },
                    { 57, "KE", "Kenya", "kenya" },
                    { 58, "SR", "Suriname", "suriname" },
                    { 59, "TZ", "Tanzania, United Republic of", "tanzania" },
                    { 60, "UM", "US Minor Outlying Islands", "us-minor-outlying-islands" },
                    { 61, "BZ", "Belize", "belize" },
                    { 34, "ES", "Spain", "spain" },
                    { 124, "FI", "Finland", "finland" },
                    { 33, "NI", "Nicaragua", "nicaragua" },
                    { 31, "MC", "Monaco", "monaco" },
                    { 4, "DO", "Dominican Republic", "dominican-republic" },
                    { 5, "MO", "Macao, SAR China", "macao-sar-china" },
                    { 6, "DM", "Dominica", "dominica" },
                    { 7, "IQ", "Iraq", "iraq" },
                    { 8, "KN", "Saint Kitts and Nevis", "saint-kitts-and-nevis" },
                    { 9, "ER", "Eritrea", "eritrea" },
                    { 10, "BN", "Brunei Darussalam", "brunei" },
                    { 11, "SO", "Somalia", "somalia" },
                    { 12, "TN", "Tunisia", "tunisia" },
                    { 13, "TM", "Turkmenistan", "turkmenistan" },
                    { 14, "AR", "Argentina", "argentina" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "CountryCode", "Name", "Slug" },
                values: new object[,]
                {
                    { 15, "CF", "Central African Republic", "central-african-republic" },
                    { 16, "VA", "Holy See (Vatican City State)", "holy-see-vatican-city-state" },
                    { 17, "LA", "Lao PDR", "lao-pdr" },
                    { 18, "MQ", "Martinique", "martinique" },
                    { 19, "TV", "Tuvalu", "tuvalu" },
                    { 20, "XK", "Republic of Kosovo", "kosovo" },
                    { 21, "TR", "Turkey", "turkey" },
                    { 22, "UG", "Uganda", "uganda" },
                    { 23, "FK", "Falkland Islands (Malvinas)", "falkland-islands-malvinas" },
                    { 24, "SC", "Seychelles", "seychelles" },
                    { 25, "AW", "Aruba", "aruba" },
                    { 26, "TT", "Trinidad and Tobago", "trinidad-and-tobago" },
                    { 27, "NR", "Nauru", "nauru" },
                    { 28, "PR", "Puerto Rico", "puerto-rico" },
                    { 29, "WS", "Samoa", "samoa" },
                    { 30, "LU", "Luxembourg", "luxembourg" },
                    { 32, "CI", "Côte d'Ivoire", "cote-divoire" },
                    { 3, "AZ", "Azerbaijan", "azerbaijan" },
                    { 63, "JO", "Jordan", "jordan" },
                    { 65, "JE", "Jersey", "jersey" },
                    { 97, "NU", "Niue", "niue" },
                    { 98, "RE", "Réunion", "réunion" },
                    { 99, "AE", "United Arab Emirates", "united-arab-emirates" },
                    { 100, "WF", "Wallis and Futuna Islands", "wallis-and-futuna-islands" },
                    { 101, "IS", "Iceland", "iceland" },
                    { 102, "LI", "Liechtenstein", "liechtenstein" },
                    { 103, "NA", "Namibia", "namibia" },
                    { 104, "SG", "Singapore", "singapore" },
                    { 105, "VE", "Venezuela (Bolivarian Republic)", "venezuela" },
                    { 106, "AO", "Angola", "angola" },
                    { 107, "GI", "Gibraltar", "gibraltar" },
                    { 108, "HN", "Honduras", "honduras" },
                    { 109, "IL", "Israel", "israel" },
                    { 110, "PN", "Pitcairn", "pitcairn" },
                    { 111, "MF", "Saint-Martin (French part)", "saint-martin-french-part" },
                    { 112, "AF", "Afghanistan", "afghanistan" },
                    { 113, "BS", "Bahamas", "bahamas" },
                    { 114, "PF", "French Polynesia", "french-polynesia" },
                    { 115, "MT", "Malta", "malta" },
                    { 116, "GB", "United Kingdom", "united-kingdom" },
                    { 117, "DZ", "Algeria", "algeria" },
                    { 118, "MX", "Mexico", "mexico" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "CountryCode", "Name", "Slug" },
                values: new object[,]
                {
                    { 119, "GS", "South Georgia and the South Sandwich Islands", "south-georgia-and-the-south-sandwich-islands" },
                    { 120, "TK", "Tokelau", "tokelau" },
                    { 121, "IO", "British Indian Ocean Territory", "british-indian-ocean-territory" },
                    { 122, "ET", "Ethiopia", "ethiopia" },
                    { 123, "LB", "Lebanon", "lebanon" },
                    { 96, "NL", "Netherlands", "netherlands" },
                    { 64, "SB", "Solomon Islands", "solomon-islands" },
                    { 95, "HM", "Heard and Mcdonald Islands", "heard-and-mcdonald-islands" },
                    { 93, "TC", "Turks and Caicos Islands", "turks-and-caicos-islands" },
                    { 66, "BL", "Saint-Barthélemy", "saint-barthélemy" },
                    { 67, "CL", "Chile", "chile" },
                    { 68, "DE", "Germany", "germany" },
                    { 69, "JM", "Jamaica", "jamaica" },
                    { 70, "MP", "Northern Mariana Islands", "northern-mariana-islands" },
                    { 71, "SE", "Sweden", "sweden" },
                    { 72, "AU", "Australia", "australia" },
                    { 73, "DK", "Denmark", "denmark" },
                    { 74, "SI", "Slovenia", "slovenia" },
                    { 75, "AI", "Anguilla", "anguilla" },
                    { 76, "VG", "British Virgin Islands", "british-virgin-islands" },
                    { 77, "CD", "Congo (Kinshasa)", "congo-kinshasa" },
                    { 78, "RU", "Russian Federation", "russia" },
                    { 79, "CX", "Christmas Island", "christmas-island" },
                    { 80, "RS", "Serbia", "serbia" },
                    { 81, "BF", "Burkina Faso", "burkina-faso" },
                    { 82, "GP", "Guadeloupe", "guadeloupe" },
                    { 83, "KZ", "Kazakhstan", "kazakhstan" },
                    { 84, "NE", "Niger", "niger" },
                    { 85, "CY", "Cyprus", "cyprus" },
                    { 86, "SV", "El Salvador", "el-salvador" },
                    { 87, "CH", "Switzerland", "switzerland" },
                    { 88, "CZ", "Czech Republic", "czech-republic" },
                    { 89, "PG", "Papua New Guinea", "papua-new-guinea" },
                    { 90, "NP", "Nepal", "nepal" },
                    { 91, "PK", "Pakistan", "pakistan" },
                    { 92, "RO", "Romania", "romania" },
                    { 94, "EG", "Egypt", "egypt" },
                    { 2, "UY", "Uruguay", "uruguay" }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "StatusOfCaseId", "Name" },
                values: new object[,]
                {
                    { 2, "recovered" },
                    { 1, "confirmed" },
                    { 3, "deaths" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cases_CountryId",
                table: "Cases",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Cases_StatusId",
                table: "Cases",
                column: "StatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cases");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Statuses");
        }
    }
}
