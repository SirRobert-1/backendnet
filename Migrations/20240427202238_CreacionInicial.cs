using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backendnet.Migrations
{
    /// <inheritdoc />
    public partial class CreacionInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Protegida = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.CategoriaId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pelicula",
                columns: table => new
                {
                    PeliculaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Titulo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Sinopsis = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Anio = table.Column<int>(type: "int", nullable: false),
                    Poster = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pelicula", x => x.PeliculaId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CategoriaPelicula",
                columns: table => new
                {
                    CategoriasCategoriaId = table.Column<int>(type: "int", nullable: false),
                    PeliculasPeliculaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaPelicula", x => new { x.CategoriasCategoriaId, x.PeliculasPeliculaId });
                    table.ForeignKey(
                        name: "FK_CategoriaPelicula_Categoria_CategoriasCategoriaId",
                        column: x => x.CategoriasCategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoriaPelicula_Pelicula_PeliculasPeliculaId",
                        column: x => x.PeliculasPeliculaId,
                        principalTable: "Pelicula",
                        principalColumn: "PeliculaId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "CategoriaId", "Nombre", "Protegida" },
                values: new object[,]
                {
                    { 1, "Acción", true },
                    { 2, "Aventura", true },
                    { 3, "Animación", true },
                    { 4, "Ciencia ficción", true },
                    { 5, "Comedia", true },
                    { 6, "Crimen", true },
                    { 7, "Documental", true },
                    { 8, "Drama", true },
                    { 9, "Familiar", true },
                    { 10, "Fantasia", true },
                    { 11, "Historia", true },
                    { 12, "Horror", true },
                    { 13, "Musica", true },
                    { 14, "Misterio", true },
                    { 15, "Romance", true }
                });

            migrationBuilder.InsertData(
                table: "Pelicula",
                columns: new[] { "PeliculaId", "Anio", "Poster", "Sinopsis", "Titulo" },
                values: new object[,]
                {
                    { 1, 0, "N/A", "El banquero Andy Dufresne es arrestado por matar a su esposa y al amante de ella, y es condenado a cadena perpetua en la prisión de Shawshank. Allí entabla amistad con Red, un preso veterano que cumple condena desde hace mucho tiempo. Andy es el blanco de abusos y violaciones por parte de los guardias y de los presos, pero se gana el respeto de Red y de los demás reclusos al ayudarles con sus problemas fiscales.", "Sueño de fuga" },
                    { 2, 0, "N/A", "Don Vito Corleone, conocido dentro de los círculos del hampa como El Padrino, es el patriarca de la familia Corleone. Después de que un intento fallido de asesinato en su contra lo deja gravemente herido, su hijo Michael se hace cargo de los negocios familiares. Michael, un veterano de guerra ajeno a los negocios de su padre, busca vengar el atentado contra su padre y se convierte en un líder implacable.", "El padrino" },
                    { 3, 0, "N/A", "Batman, el comisario Gordon y el nuevo fiscal del distrito Harvey Dent unen fuerzas para acabar con el crimen organizado en Ciudad Gótica. Sin embargo, se encontrarán con un genio criminal conocido como Joker, que provocará el caos en la ciudad.", "El caballero oscuro" },
                    { 4, 0, "N/A", "La última parte de la trilogía de El Señor de los Anillos. La oscuridad se cierne sobre la Tierra Media. Después de que el oscuro señor Sauron ordenara a sus tropas que atacaran Minas Tirith, la capital de Gondor, el rey Theoden de Rohan reúne a sus aliados para ayudar a defender la ciudad fortificada. Mientras tanto, Frodo y Sam llevan el anillo a Mordor, la única esperanza para la supervivencia de la Tierra Media.", "El retorno del rey" },
                    { 5, 0, "N/A", "En Los Ángeles, en 1992, el crimen y la violencia se han apoderado de la ciudad. El exconvicto Lenny Nero vende un nuevo tipo de droga llamada SQUID, que permite a los usuarios experimentar los recuerdos y sensaciones de otras personas. Cuando una prostituta amiga suya es asesinada, Lenny se ve envuelto en una trama de corrupción y violencia.", "Tiempos violentos" },
                    { 6, 0, "N/A", "Forrest Gump es un hombre con un coeficiente intelectual por debajo de la media, pero con una vida plena. A lo largo de su vida, Forrest se ve envuelto en situaciones históricas importantes, como la guerra de Vietnam y la lucha por los derechos civiles. A pesar de sus limitaciones, Forrest siempre se mantiene fiel a sus amigos y a sus ideales.", "Forest Gump" },
                    { 7, 0, "N/A", "Un joven sin nombre y sin rumbo en la vida conoce a Tyler Durden, un vendedor de jabón con una filosofía muy particular. Juntos, crean un club de lucha clandestino que se convierte en un movimiento revolucionario. Sin embargo, la relación entre los dos se complica cuando conocen a Marla Singer, una mujer misteriosa que se convierte en el objeto de deseo de ambos.", "El club de la pelea" },
                    { 8, 0, "N/A", "Dom Cobb es un ladrón de sueños que se dedica a robar secretos de la mente de las personas mientras duermen. Cuando se le ofrece la oportunidad de redimirse a cambio de una última misión, Cobb acepta el desafío de implantar una idea en la mente de un empresario rival. Sin embargo, la misión se complica cuando Cobb se enfrenta a sus propios demonios y a los secretos de su pasado.", "Inception" },
                    { 9, 0, "N/A", "Después de la destrucción de la Estrella de la Muerte, la Alianza Rebelde se ha refugiado en el planeta Hoth. Mientras tanto, Darth Vader ha puesto en marcha un plan para capturar a Luke Skywalker y convertirlo en un Sith. Luke, Leia, Han Solo y Chewbacca se ven obligados a huir de Hoth y buscar refugio en la ciudad de las nubes, donde se enfrentarán a un enemigo inesperado.", "Star Wars Episodio V: El imperio contraataca" },
                    { 10, 0, "N/A", "Thomas Anderson es un programador de software que lleva una doble vida como hacker informático conocido como Neo. Cuando es contactado por Morfeo, un misterioso líder de la resistencia, Neo descubre que el mundo en el que vive es una simulación creada por máquinas inteligentes. Morfeo le ofrece la oportunidad de unirse a la resistencia y luchar contra las máquinas, pero Neo deberá enfrentarse a sus propios miedos y dudas para convertirse en el Elegido.", "Matrix" },
                    { 11, 0, "N/A", "En un futuro distópico, la Tierra se está muriendo debido a la falta de recursos naturales. Un grupo de astronautas es enviado en una misión espacial para encontrar un nuevo planeta habitable para la humanidad. Sin embargo, la misión se complica cuando los astronautas se enfrentan a peligros desconocidos y a la traición de uno de sus miembros.", "Interestelar" },
                    { 12, 0, "N/A", "La segunda parte de la adaptación de la novela de ciencia ficción de Frank Herbert. Después de la traición de su tío, Paul Atreides se convierte en el líder de la tribu Fremen y se embarca en una misión para liberar el planeta Arrakis del control de la Casa Harkonnen. Sin embargo, Paul descubre que su destino está ligado a un antiguo profeta y a una misteriosa profecía que podría cambiar el curso de la historia.", "Dune: Parte dos" },
                    { 13, 0, "N/A", "Después de la destrucción del T-800 en Los Ángeles, Sarah Connor y su hijo John se han escondido en México para evitar ser capturados por Skynet. Sin embargo, un nuevo Terminator, el T-1000, es enviado desde el futuro para eliminar a John. Sarah y John se unen a un T-800 reprogramado para protegerlos y juntos intentan detener el juicio final y salvar a la humanidad de la extinción.", "Terminator 2: El juicio final" },
                    { 14, 0, "N/A", "Marty McFly es un adolescente de los años 80 que viaja en el tiempo a 1955 en un DeLorean modificado por el Dr. Emmett Brown. Allí, Marty conoce a sus padres antes de que se conozcan y cambia el curso de la historia. Ahora, Marty debe encontrar una forma de arreglar las cosas y regresar a su tiempo antes de que sea demasiado tarde.", "Volver al futuro" },
                    { 15, 0, "N/A", "Vivir en Barbie Land es el sueño de muchas niñas. Barbie es una muñeca de plástico que ha sido un icono de la moda y la belleza desde su creación en 1959. Con su cabello rubio, su sonrisa perfecta y su guardarropa interminable, Barbie ha inspirado a generaciones de niñas a soñar en grande y a creer en sí mismas.", "Barbie" }
                });

            migrationBuilder.InsertData(
                table: "CategoriaPelicula",
                columns: new[] { "CategoriasCategoriaId", "PeliculasPeliculaId" },
                values: new object[,]
                {
                    { 1, 3 },
                    { 1, 8 },
                    { 1, 9 },
                    { 1, 10 },
                    { 1, 11 },
                    { 1, 12 },
                    { 1, 13 },
                    { 2, 3 },
                    { 2, 8 },
                    { 2, 9 },
                    { 2, 11 },
                    { 2, 12 },
                    { 2, 13 },
                    { 2, 14 },
                    { 2, 15 },
                    { 4, 10 },
                    { 4, 11 },
                    { 4, 13 },
                    { 4, 14 },
                    { 5, 14 },
                    { 5, 15 },
                    { 6, 1 },
                    { 6, 2 },
                    { 6, 5 },
                    { 8, 2 },
                    { 8, 3 },
                    { 8, 4 },
                    { 8, 5 },
                    { 8, 6 },
                    { 8, 7 },
                    { 8, 12 },
                    { 10, 9 },
                    { 10, 15 },
                    { 15, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoriaPelicula_PeliculasPeliculaId",
                table: "CategoriaPelicula",
                column: "PeliculasPeliculaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoriaPelicula");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Pelicula");
        }
    }
}
