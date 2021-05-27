using Microsoft.EntityFrameworkCore.Migrations;

namespace Covid19_Services_Backend.Migrations
{
    public partial class modifyCaseTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CasesId",
                table: "Cases",
                newName: "NumberOfCases");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 1,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "LI", "Liechtenstein", "liechtenstein" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 2,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "NC", "New Caledonia", "new-caledonia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 3,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "UA", "Ukraine", "ukraine" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 4,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "UM", "US Minor Outlying Islands", "us-minor-outlying-islands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 5,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "KY", "Cayman Islands", "cayman-islands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 6,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "GE", "Georgia", "georgia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 7,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "KP", "Korea (North)", "korea-north" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 8,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "ML", "Mali", "mali" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 9,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "ST", "Sao Tome and Principe", "sao-tome-and-principe" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 10,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "TC", "Turks and Caicos Islands", "turks-and-caicos-islands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 11,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "AQ", "Antarctica", "antarctica" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 12,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "BO", "Bolivia", "bolivia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 13,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "GM", "Gambia", "gambia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 14,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "JO", "Jordan", "jordan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 15,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "MY", "Malaysia", "malaysia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 16,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "PS", "Palestinian Territory", "palestine" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 17,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "SJ", "Svalbard and Jan Mayen Islands", "svalbard-and-jan-mayen-islands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 18,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "TJ", "Tajikistan", "tajikistan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 19,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "TZ", "Tanzania, United Republic of", "tanzania" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 20,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "ZW", "Zimbabwe", "zimbabwe" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 21,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "AF", "Afghanistan", "afghanistan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 22,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "KG", "Kyrgyzstan", "kyrgyzstan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 23,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "MV", "Maldives", "maldives" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 24,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "AM", "Armenia", "armenia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 25,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "MR", "Mauritania", "mauritania" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 26,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "ME", "Montenegro", "montenegro" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 27,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "WF", "Wallis and Futuna Islands", "wallis-and-futuna-islands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 28,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "MD", "Moldova", "moldova" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 29,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "PW", "Palau", "palau" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 30,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "TD", "Chad", "chad" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 31,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "IQ", "Iraq", "iraq" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 32,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "LS", "Lesotho", "lesotho" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 33,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "MU", "Mauritius", "mauritius" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 34,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "IO", "British Indian Ocean Territory", "british-indian-ocean-territory" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 35,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "CG", "Congo (Brazzaville)", "congo-brazzaville" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 36,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "SB", "Solomon Islands", "solomon-islands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 37,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "TR", "Turkey", "turkey" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 38,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "EC", "Ecuador", "ecuador" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 39,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "MT", "Malta", "malta" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 40,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "PG", "Papua New Guinea", "papua-new-guinea" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 41,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "PH", "Philippines", "philippines" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 42,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "TM", "Turkmenistan", "turkmenistan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 43,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "VI", "Virgin Islands, US", "virgin-islands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 44,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "KM", "Comoros", "comoros" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 45,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "ZA", "South Africa", "south-africa" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 46,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "NR", "Nauru", "nauru" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 47,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "AW", "Aruba", "aruba" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 48,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "BN", "Brunei Darussalam", "brunei" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 49,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "CC", "Cocos (Keeling) Islands", "cocos-keeling-islands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 50,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "DE", "Germany", "germany" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 51,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "VA", "Holy See (Vatican City State)", "holy-see-vatican-city-state" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 52,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "IL", "Israel", "israel" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 53,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "SG", "Singapore", "singapore" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 54,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "CN", "China", "china" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 55,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "HU", "Hungary", "hungary" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 56,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "IN", "India", "india" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 57,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "LU", "Luxembourg", "luxembourg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 58,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "SM", "San Marino", "san-marino" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 59,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "KH", "Cambodia", "cambodia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 60,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "AX", "ALA Aland Islands", "ala-aland-islands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 61,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "BE", "Belgium", "belgium" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 62,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "BJ", "Benin", "benin" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 63,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "IR", "Iran, Islamic Republic of", "iran" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 64,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "MC", "Monaco", "monaco" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 65,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "PN", "Pitcairn", "pitcairn" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 66,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "DM", "Dominica", "dominica" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 67,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "JM", "Jamaica", "jamaica" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 68,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "LY", "Libya", "libya" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 69,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "MO", "Macao, SAR China", "macao-sar-china" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 70,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "TG", "Togo", "togo" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 71,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "UG", "Uganda", "uganda" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 72,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "BR", "Brazil", "brazil" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 73,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "KW", "Kuwait", "kuwait" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 74,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "LV", "Latvia", "latvia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 75,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "MZ", "Mozambique", "mozambique" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 76,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "SY", "Syrian Arab Republic (Syria)", "syria" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 77,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "VN", "Viet Nam", "vietnam" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 78,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "AS", "American Samoa", "american-samoa" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 79,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "KZ", "Kazakhstan", "kazakhstan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 80,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "NZ", "New Zealand", "new-zealand" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 81,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "SH", "Saint Helena", "saint-helena" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 82,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "IE", "Ireland", "ireland" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 83,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "BV", "Bouvet Island", "bouvet-island" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 84,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "GQ", "Equatorial Guinea", "equatorial-guinea" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 85,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "GI", "Gibraltar", "gibraltar" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 86,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "GW", "Guinea-Bissau", "guinea-bissau" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 87,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "GY", "Guyana", "guyana" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 88,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "FM", "Micronesia, Federated States of", "micronesia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 89,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "BG", "Bulgaria", "bulgaria" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 90,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "HR", "Croatia", "croatia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 91,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "PF", "French Polynesia", "french-polynesia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 92,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "GP", "Guadeloupe", "guadeloupe" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 93,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "GN", "Guinea", "guinea" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 94,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "HN", "Honduras", "honduras" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 95,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "QA", "Qatar", "qatar" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 96,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "RS", "Serbia", "serbia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 97,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "TN", "Tunisia", "tunisia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 98,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "BF", "Burkina Faso", "burkina-faso" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 99,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "AL", "Albania", "albania" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 100,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "EE", "Estonia", "estonia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 101,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "NP", "Nepal", "nepal" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 102,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "SS", "South Sudan", "south-sudan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 103,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "BH", "Bahrain", "bahrain" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 104,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "US", "United States of America", "united-states" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 105,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "DJ", "Djibouti", "djibouti" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 106,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "FI", "Finland", "finland" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 107,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "SE", "Sweden", "sweden" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 108,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "EH", "Western Sahara", "western-sahara" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 109,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "ZM", "Zambia", "zambia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 110,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "WS", "Samoa", "samoa" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 111,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "JP", "Japan", "japan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 112,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "GR", "Greece", "greece" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 113,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "AI", "Anguilla", "anguilla" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 114,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "CO", "Colombia", "colombia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 115,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "CY", "Cyprus", "cyprus" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 116,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "KE", "Kenya", "kenya" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 117,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "LK", "Sri Lanka", "sri-lanka" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 118,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "TL", "Timor-Leste", "timor-leste" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 119,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "BB", "Barbados", "barbados" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 120,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "CA", "Canada", "canada" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 121,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "GT", "Guatemala", "guatemala" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 122,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "FO", "Faroe Islands", "faroe-islands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 123,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "MK", "Macedonia, Republic of", "macedonia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 124,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "SD", "Sudan", "sudan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 125,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "OM", "Oman", "oman" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 126,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "GF", "French Guiana", "french-guiana" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 127,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "GA", "Gabon", "gabon" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 128,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "MG", "Madagascar", "madagascar" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 129,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "SL", "Sierra Leone", "sierra-leone" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 130,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "SR", "Suriname", "suriname" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 131,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "CD", "Congo (Kinshasa)", "congo-kinshasa" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 132,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "CU", "Cuba", "cuba" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 133,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "PM", "Saint Pierre and Miquelon", "saint-pierre-and-miquelon" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 134,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "BY", "Belarus", "belarus" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 135,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "BW", "Botswana", "botswana" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 136,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "BI", "Burundi", "burundi" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 137,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "ER", "Eritrea", "eritrea" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 138,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "FJ", "Fiji", "fiji" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 139,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "LT", "Lithuania", "lithuania" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 140,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "MP", "Northern Mariana Islands", "northern-mariana-islands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 141,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "VC", "Saint Vincent and Grenadines", "saint-vincent-and-the-grenadines" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 142,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "BT", "Bhutan", "bhutan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 143,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "TH", "Thailand", "thailand" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 144,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "BZ", "Belize", "belize" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 145,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "CF", "Central African Republic", "central-african-republic" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 146,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "XK", "Republic of Kosovo", "kosovo" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 147,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "AO", "Angola", "angola" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 148,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "FK", "Falkland Islands (Malvinas)", "falkland-islands-malvinas" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 149,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "NE", "Niger", "niger" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 150,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "NO", "Norway", "norway" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 151,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "TW", "Taiwan, Republic of China", "taiwan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 152,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "GB", "United Kingdom", "united-kingdom" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 153,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "AG", "Antigua and Barbuda", "antigua-and-barbuda" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 154,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "SV", "El Salvador", "el-salvador" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 155,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "GD", "Grenada", "grenada" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 156,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "LA", "Lao PDR", "lao-pdr" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 157,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "AU", "Australia", "australia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 158,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "CL", "Chile", "chile" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 159,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "CX", "Christmas Island", "christmas-island" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 160,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "MS", "Montserrat", "montserrat" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 161,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "AR", "Argentina", "argentina" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 162,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "MX", "Mexico", "mexico" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 163,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "PT", "Portugal", "portugal" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 164,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "BM", "Bermuda", "bermuda" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 165,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "EG", "Egypt", "egypt" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 166,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "ID", "Indonesia", "indonesia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 167,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "JE", "Jersey", "jersey" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 168,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "CR", "Costa Rica", "costa-rica" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 169,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "CI", "Côte d'Ivoire", "cote-divoire" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 170,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "LR", "Liberia", "liberia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 171,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "MA", "Morocco", "morocco" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 172,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "MM", "Myanmar", "myanmar" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 173,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "VU", "Vanuatu", "vanuatu" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 174,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "AD", "Andorra", "andorra" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 175,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "KI", "Kiribati", "kiribati" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 176,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "RW", "Rwanda", "rwanda" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 177,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "ES", "Spain", "spain" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 178,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "TO", "Tonga", "tonga" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 179,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "CH", "Switzerland", "switzerland" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 180,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "TK", "Tokelau", "tokelau" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 181,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "GU", "Guam", "guam" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 182,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "DO", "Dominican Republic", "dominican-republic" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 183,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "IM", "Isle of Man", "isle-of-man" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 184,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "MQ", "Martinique", "martinique" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 185,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "YT", "Mayotte", "mayotte" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 186,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "RU", "Russian Federation", "russia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 187,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "SZ", "Swaziland", "swaziland" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 188,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "PE", "Peru", "peru" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 189,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "RE", "Réunion", "réunion" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 190,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "FR", "France", "france" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 191,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "GH", "Ghana", "ghana" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 192,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "GL", "Greenland", "greenland" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 193,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "HT", "Haiti", "haiti" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 194,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "KR", "Korea (South)", "korea-south" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 195,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "PY", "Paraguay", "paraguay" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 196,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "ET", "Ethiopia", "ethiopia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 197,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "SC", "Seychelles", "seychelles" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 198,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "DK", "Denmark", "denmark" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 199,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "AT", "Austria", "austria" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 200,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "BA", "Bosnia and Herzegovina", "bosnia-and-herzegovina" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 201,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "NI", "Nicaragua", "nicaragua" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 202,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "SN", "Senegal", "senegal" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 203,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "MW", "Malawi", "malawi" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 204,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "PR", "Puerto Rico", "puerto-rico" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 205,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "KN", "Saint Kitts and Nevis", "saint-kitts-and-nevis" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 206,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "UZ", "Uzbekistan", "uzbekistan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 207,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "AZ", "Azerbaijan", "azerbaijan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 208,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "PL", "Poland", "poland" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 209,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "CZ", "Czech Republic", "czech-republic" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 210,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "NF", "Norfolk Island", "norfolk-island" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 211,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "RO", "Romania", "romania" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 212,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "LC", "Saint Lucia", "saint-lucia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 213,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "GS", "South Georgia and the South Sandwich Islands", "south-georgia-and-the-south-sandwich-islands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 214,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "BL", "Saint-Barthélemy", "saint-barthélemy" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 215,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "BD", "Bangladesh", "bangladesh" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 216,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "CV", "Cape Verde", "cape-verde" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 217,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "SO", "Somalia", "somalia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 218,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "YE", "Yemen", "yemen" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 219,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "CM", "Cameroon", "cameroon" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 220,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "SI", "Slovenia", "slovenia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 221,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "IT", "Italy", "italy" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 222,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "VE", "Venezuela (Bolivarian Republic)", "venezuela" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 223,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "BS", "Bahamas", "bahamas" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 224,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "HM", "Heard and Mcdonald Islands", "heard-and-mcdonald-islands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 225,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "MN", "Mongolia", "mongolia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 226,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "PK", "Pakistan", "pakistan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 227,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "VG", "British Virgin Islands", "british-virgin-islands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 228,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "CK", "Cook Islands", "cook-islands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 229,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "IS", "Iceland", "iceland" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 230,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "TV", "Tuvalu", "tuvalu" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 231,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "MH", "Marshall Islands", "marshall-islands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 232,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "TT", "Trinidad and Tobago", "trinidad-and-tobago" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 233,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "UY", "Uruguay", "uruguay" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 234,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "GG", "Guernsey", "guernsey" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 235,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "DZ", "Algeria", "algeria" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 236,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "TF", "French Southern Territories", "french-southern-territories" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 237,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "LB", "Lebanon", "lebanon" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 238,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "NG", "Nigeria", "nigeria" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 239,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "HK", "Hong Kong, SAR China", "hong-kong-sar-china" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 240,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "MF", "Saint-Martin (French part)", "saint-martin-french-part" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 241,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "AN", "Netherlands Antilles", "netherlands-antilles" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 242,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "NU", "Niue", "niue" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 243,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "PA", "Panama", "panama" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 244,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "NL", "Netherlands", "netherlands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 245,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "SA", "Saudi Arabia", "saudi-arabia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 246,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "SK", "Slovakia", "slovakia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 247,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "AE", "United Arab Emirates", "united-arab-emirates" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 248,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "NA", "Namibia", "namibia" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NumberOfCases",
                table: "Cases",
                newName: "CasesId");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 1,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "EC", "Ecuador", "ecuador" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 2,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "UY", "Uruguay", "uruguay" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 3,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "AZ", "Azerbaijan", "azerbaijan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 4,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "DO", "Dominican Republic", "dominican-republic" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 5,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "MO", "Macao, SAR China", "macao-sar-china" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 6,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "DM", "Dominica", "dominica" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 7,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "IQ", "Iraq", "iraq" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 8,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "KN", "Saint Kitts and Nevis", "saint-kitts-and-nevis" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 9,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "ER", "Eritrea", "eritrea" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 10,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "BN", "Brunei Darussalam", "brunei" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 11,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "SO", "Somalia", "somalia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 12,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "TN", "Tunisia", "tunisia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 13,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "TM", "Turkmenistan", "turkmenistan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 14,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "AR", "Argentina", "argentina" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 15,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "CF", "Central African Republic", "central-african-republic" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 16,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "VA", "Holy See (Vatican City State)", "holy-see-vatican-city-state" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 17,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "LA", "Lao PDR", "lao-pdr" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 18,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "MQ", "Martinique", "martinique" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 19,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "TV", "Tuvalu", "tuvalu" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 20,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "XK", "Republic of Kosovo", "kosovo" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 21,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "TR", "Turkey", "turkey" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 22,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "UG", "Uganda", "uganda" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 23,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "FK", "Falkland Islands (Malvinas)", "falkland-islands-malvinas" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 24,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "SC", "Seychelles", "seychelles" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 25,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "AW", "Aruba", "aruba" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 26,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "TT", "Trinidad and Tobago", "trinidad-and-tobago" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 27,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "NR", "Nauru", "nauru" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 28,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "PR", "Puerto Rico", "puerto-rico" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 29,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "WS", "Samoa", "samoa" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 30,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "LU", "Luxembourg", "luxembourg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 31,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "MC", "Monaco", "monaco" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 32,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "CI", "Côte d'Ivoire", "cote-divoire" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 33,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "NI", "Nicaragua", "nicaragua" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 34,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "ES", "Spain", "spain" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 35,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "YE", "Yemen", "yemen" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 36,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "MA", "Morocco", "morocco" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 37,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "TO", "Tonga", "tonga" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 38,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "AS", "American Samoa", "american-samoa" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 39,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "BG", "Bulgaria", "bulgaria" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 40,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "CC", "Cocos (Keeling) Islands", "cocos-keeling-islands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 41,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "BM", "Bermuda", "bermuda" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 42,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "GU", "Guam", "guam" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 43,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "SS", "South Sudan", "south-sudan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 44,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "FO", "Faroe Islands", "faroe-islands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 45,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "TJ", "Tajikistan", "tajikistan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 46,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "BW", "Botswana", "botswana" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 47,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "KY", "Cayman Islands", "cayman-islands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 48,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "MM", "Myanmar", "myanmar" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 49,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "GE", "Georgia", "georgia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 50,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "AM", "Armenia", "armenia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 51,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "CO", "Colombia", "colombia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 52,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "KW", "Kuwait", "kuwait" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 53,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "MG", "Madagascar", "madagascar" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 54,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "BB", "Barbados", "barbados" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 55,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "IM", "Isle of Man", "isle-of-man" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 56,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "KI", "Kiribati", "kiribati" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 57,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "KE", "Kenya", "kenya" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 58,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "SR", "Suriname", "suriname" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 59,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "TZ", "Tanzania, United Republic of", "tanzania" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 60,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "UM", "US Minor Outlying Islands", "us-minor-outlying-islands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 61,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "BZ", "Belize", "belize" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 62,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "BA", "Bosnia and Herzegovina", "bosnia-and-herzegovina" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 63,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "JO", "Jordan", "jordan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 64,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "SB", "Solomon Islands", "solomon-islands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 65,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "JE", "Jersey", "jersey" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 66,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "BL", "Saint-Barthélemy", "saint-barthélemy" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 67,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "CL", "Chile", "chile" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 68,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "DE", "Germany", "germany" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 69,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "JM", "Jamaica", "jamaica" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 70,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "MP", "Northern Mariana Islands", "northern-mariana-islands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 71,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "SE", "Sweden", "sweden" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 72,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "AU", "Australia", "australia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 73,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "DK", "Denmark", "denmark" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 74,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "SI", "Slovenia", "slovenia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 75,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "AI", "Anguilla", "anguilla" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 76,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "VG", "British Virgin Islands", "british-virgin-islands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 77,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "CD", "Congo (Kinshasa)", "congo-kinshasa" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 78,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "RU", "Russian Federation", "russia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 79,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "CX", "Christmas Island", "christmas-island" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 80,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "RS", "Serbia", "serbia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 81,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "BF", "Burkina Faso", "burkina-faso" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 82,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "GP", "Guadeloupe", "guadeloupe" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 83,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "KZ", "Kazakhstan", "kazakhstan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 84,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "NE", "Niger", "niger" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 85,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "CY", "Cyprus", "cyprus" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 86,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "SV", "El Salvador", "el-salvador" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 87,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "CH", "Switzerland", "switzerland" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 88,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "CZ", "Czech Republic", "czech-republic" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 89,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "PG", "Papua New Guinea", "papua-new-guinea" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 90,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "NP", "Nepal", "nepal" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 91,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "PK", "Pakistan", "pakistan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 92,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "RO", "Romania", "romania" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 93,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "TC", "Turks and Caicos Islands", "turks-and-caicos-islands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 94,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "EG", "Egypt", "egypt" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 95,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "HM", "Heard and Mcdonald Islands", "heard-and-mcdonald-islands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 96,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "NL", "Netherlands", "netherlands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 97,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "NU", "Niue", "niue" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 98,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "RE", "Réunion", "réunion" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 99,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "AE", "United Arab Emirates", "united-arab-emirates" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 100,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "WF", "Wallis and Futuna Islands", "wallis-and-futuna-islands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 101,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "IS", "Iceland", "iceland" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 102,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "LI", "Liechtenstein", "liechtenstein" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 103,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "NA", "Namibia", "namibia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 104,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "SG", "Singapore", "singapore" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 105,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "VE", "Venezuela (Bolivarian Republic)", "venezuela" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 106,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "AO", "Angola", "angola" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 107,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "GI", "Gibraltar", "gibraltar" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 108,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "HN", "Honduras", "honduras" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 109,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "IL", "Israel", "israel" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 110,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "PN", "Pitcairn", "pitcairn" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 111,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "MF", "Saint-Martin (French part)", "saint-martin-french-part" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 112,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "AF", "Afghanistan", "afghanistan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 113,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "BS", "Bahamas", "bahamas" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 114,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "PF", "French Polynesia", "french-polynesia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 115,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "MT", "Malta", "malta" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 116,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "GB", "United Kingdom", "united-kingdom" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 117,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "DZ", "Algeria", "algeria" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 118,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "MX", "Mexico", "mexico" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 119,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "GS", "South Georgia and the South Sandwich Islands", "south-georgia-and-the-south-sandwich-islands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 120,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "TK", "Tokelau", "tokelau" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 121,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "IO", "British Indian Ocean Territory", "british-indian-ocean-territory" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 122,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "ET", "Ethiopia", "ethiopia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 123,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "LB", "Lebanon", "lebanon" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 124,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "FI", "Finland", "finland" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 125,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "GM", "Gambia", "gambia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 126,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "HU", "Hungary", "hungary" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 127,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "KR", "Korea (South)", "korea-south" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 128,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "LV", "Latvia", "latvia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 129,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "EH", "Western Sahara", "western-sahara" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 130,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "NO", "Norway", "norway" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 131,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "SL", "Sierra Leone", "sierra-leone" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 132,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "GA", "Gabon", "gabon" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 133,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "MR", "Mauritania", "mauritania" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 134,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "GH", "Ghana", "ghana" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 135,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "GG", "Guernsey", "guernsey" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 136,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "PY", "Paraguay", "paraguay" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 137,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "SM", "San Marino", "san-marino" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 138,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "CR", "Costa Rica", "costa-rica" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 139,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "TF", "French Southern Territories", "french-southern-territories" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 140,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "CV", "Cape Verde", "cape-verde" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 141,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "SA", "Saudi Arabia", "saudi-arabia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 142,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "VU", "Vanuatu", "vanuatu" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 143,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "ID", "Indonesia", "indonesia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 144,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "JP", "Japan", "japan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 145,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "MW", "Malawi", "malawi" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 146,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "DJ", "Djibouti", "djibouti" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 147,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "VC", "Saint Vincent and Grenadines", "saint-vincent-and-the-grenadines" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 148,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "SJ", "Svalbard and Jan Mayen Islands", "svalbard-and-jan-mayen-islands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 149,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "AQ", "Antarctica", "antarctica" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 150,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "CU", "Cuba", "cuba" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 151,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "GW", "Guinea-Bissau", "guinea-bissau" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 152,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "LT", "Lithuania", "lithuania" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 153,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "FM", "Micronesia, Federated States of", "micronesia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 154,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "MD", "Moldova", "moldova" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 155,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "TD", "Chad", "chad" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 156,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "KM", "Comoros", "comoros" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 157,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "PS", "Palestinian Territory", "palestine" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 158,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "ME", "Montenegro", "montenegro" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 159,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "NZ", "New Zealand", "new-zealand" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 160,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "PW", "Palau", "palau" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 161,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "GL", "Greenland", "greenland" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 162,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "PL", "Poland", "poland" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 163,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "SY", "Syrian Arab Republic (Syria)", "syria" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 164,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "ZW", "Zimbabwe", "zimbabwe" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 165,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "AX", "ALA Aland Islands", "ala-aland-islands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 166,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "BV", "Bouvet Island", "bouvet-island" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 167,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "CK", "Cook Islands", "cook-islands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 168,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "MK", "Macedonia, Republic of", "macedonia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 169,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "MY", "Malaysia", "malaysia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 170,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "HR", "Croatia", "croatia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 171,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "PA", "Panama", "panama" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 172,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "BY", "Belarus", "belarus" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 173,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "BO", "Bolivia", "bolivia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 174,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "GD", "Grenada", "grenada" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 175,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "MV", "Maldives", "maldives" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 176,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "NC", "New Caledonia", "new-caledonia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 177,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "VI", "Virgin Islands, US", "virgin-islands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 178,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "AT", "Austria", "austria" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 179,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "CA", "Canada", "canada" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 180,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "CN", "China", "china" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 181,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "TW", "Taiwan, Republic of China", "taiwan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 182,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "BD", "Bangladesh", "bangladesh" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 183,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "GT", "Guatemala", "guatemala" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 184,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "NF", "Norfolk Island", "norfolk-island" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 185,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "EE", "Estonia", "estonia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 186,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "GF", "French Guiana", "french-guiana" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 187,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "RW", "Rwanda", "rwanda" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 188,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "ZA", "South Africa", "south-africa" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 189,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "BT", "Bhutan", "bhutan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 190,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "MN", "Mongolia", "mongolia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 191,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "HK", "Hong Kong, SAR China", "hong-kong-sar-china" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 192,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "ML", "Mali", "mali" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 193,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "PE", "Peru", "peru" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 194,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "TG", "Togo", "togo" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 195,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "BH", "Bahrain", "bahrain" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 196,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "LR", "Liberia", "liberia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 197,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "LK", "Sri Lanka", "sri-lanka" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 198,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "VN", "Viet Nam", "vietnam" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 199,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "KP", "Korea (North)", "korea-north" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 200,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "SH", "Saint Helena", "saint-helena" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 201,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "ST", "Sao Tome and Principe", "sao-tome-and-principe" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 202,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "ZM", "Zambia", "zambia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 203,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "LS", "Lesotho", "lesotho" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 204,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "US", "United States of America", "united-states" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 205,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "HT", "Haiti", "haiti" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 206,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "BJ", "Benin", "benin" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 207,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "FJ", "Fiji", "fiji" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 208,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "FR", "France", "france" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 209,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "IR", "Iran, Islamic Republic of", "iran" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 210,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "KG", "Kyrgyzstan", "kyrgyzstan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 211,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "SZ", "Swaziland", "swaziland" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 212,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "UZ", "Uzbekistan", "uzbekistan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 213,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "AG", "Antigua and Barbuda", "antigua-and-barbuda" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 214,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "CG", "Congo (Brazzaville)", "congo-brazzaville" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 215,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "GQ", "Equatorial Guinea", "equatorial-guinea" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 216,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "YT", "Mayotte", "mayotte" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 217,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "OM", "Oman", "oman" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 218,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "QA", "Qatar", "qatar" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 219,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "PM", "Saint Pierre and Miquelon", "saint-pierre-and-miquelon" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 220,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "SK", "Slovakia", "slovakia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 221,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "GR", "Greece", "greece" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 222,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "GN", "Guinea", "guinea" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 223,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "TL", "Timor-Leste", "timor-leste" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 224,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "BE", "Belgium", "belgium" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 225,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "PT", "Portugal", "portugal" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 226,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "SD", "Sudan", "sudan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 227,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "AN", "Netherlands Antilles", "netherlands-antilles" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 228,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "SN", "Senegal", "senegal" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 229,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "UA", "Ukraine", "ukraine" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 230,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "GY", "Guyana", "guyana" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 231,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "MZ", "Mozambique", "mozambique" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 232,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "NG", "Nigeria", "nigeria" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 233,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "LY", "Libya", "libya" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 234,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "MU", "Mauritius", "mauritius" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 235,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "PH", "Philippines", "philippines" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 236,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "LC", "Saint Lucia", "saint-lucia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 237,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "AL", "Albania", "albania" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 238,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "AD", "Andorra", "andorra" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 239,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "KH", "Cambodia", "cambodia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 240,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "BI", "Burundi", "burundi" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 241,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "CM", "Cameroon", "cameroon" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 242,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "MH", "Marshall Islands", "marshall-islands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 243,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "BR", "Brazil", "brazil" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 244,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "MS", "Montserrat", "montserrat" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 245,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "TH", "Thailand", "thailand" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 246,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "IN", "India", "india" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 247,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "IE", "Ireland", "ireland" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 248,
                columns: new[] { "CountryCode", "Name", "Slug" },
                values: new object[] { "IT", "Italy", "italy" });
        }
    }
}
