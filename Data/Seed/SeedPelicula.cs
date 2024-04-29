using backendnet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backendnet.Data.Seed;

public class SeedPelicula : IEntityTypeConfiguration<Pelicula>
{
    public void Configure(EntityTypeBuilder<Pelicula> builder)
    {
        builder.HasData(
            new Pelicula { PeliculaId = 1, Titulo = "Sueño de fuga", Sinopsis = "El banquero Andy Dufresne es arrestado por matar a su esposa y al amante de ella, y es condenado a cadena perpetua en la prisión de Shawshank. Allí entabla amistad con Red, un preso veterano que cumple condena desde hace mucho tiempo. Andy es el blanco de abusos y violaciones por parte de los guardias y de los presos, pero se gana el respeto de Red y de los demás reclusos al ayudarles con sus problemas fiscales." },
            new Pelicula { PeliculaId = 2, Titulo = "El padrino", Sinopsis = "Don Vito Corleone, conocido dentro de los círculos del hampa como El Padrino, es el patriarca de la familia Corleone. Después de que un intento fallido de asesinato en su contra lo deja gravemente herido, su hijo Michael se hace cargo de los negocios familiares. Michael, un veterano de guerra ajeno a los negocios de su padre, busca vengar el atentado contra su padre y se convierte en un líder implacable." },
            new Pelicula { PeliculaId = 3, Titulo = "El caballero oscuro", Sinopsis = "Batman, el comisario Gordon y el nuevo fiscal del distrito Harvey Dent unen fuerzas para acabar con el crimen organizado en Ciudad Gótica. Sin embargo, se encontrarán con un genio criminal conocido como Joker, que provocará el caos en la ciudad." },
            new Pelicula { PeliculaId = 4, Titulo = "El retorno del rey", Sinopsis = "La última parte de la trilogía de El Señor de los Anillos. La oscuridad se cierne sobre la Tierra Media. Después de que el oscuro señor Sauron ordenara a sus tropas que atacaran Minas Tirith, la capital de Gondor, el rey Theoden de Rohan reúne a sus aliados para ayudar a defender la ciudad fortificada. Mientras tanto, Frodo y Sam llevan el anillo a Mordor, la única esperanza para la supervivencia de la Tierra Media." },
            new Pelicula { PeliculaId = 5, Titulo = "Tiempos violentos", Sinopsis = "En Los Ángeles, en 1992, el crimen y la violencia se han apoderado de la ciudad. El exconvicto Lenny Nero vende un nuevo tipo de droga llamada SQUID, que permite a los usuarios experimentar los recuerdos y sensaciones de otras personas. Cuando una prostituta amiga suya es asesinada, Lenny se ve envuelto en una trama de corrupción y violencia." },
            new Pelicula { PeliculaId = 6, Titulo = "Forest Gump", Sinopsis = "Forrest Gump es un hombre con un coeficiente intelectual por debajo de la media, pero con una vida plena. A lo largo de su vida, Forrest se ve envuelto en situaciones históricas importantes, como la guerra de Vietnam y la lucha por los derechos civiles. A pesar de sus limitaciones, Forrest siempre se mantiene fiel a sus amigos y a sus ideales." },
            new Pelicula { PeliculaId = 7, Titulo = "El club de la pelea", Sinopsis = "Un joven sin nombre y sin rumbo en la vida conoce a Tyler Durden, un vendedor de jabón con una filosofía muy particular. Juntos, crean un club de lucha clandestino que se convierte en un movimiento revolucionario. Sin embargo, la relación entre los dos se complica cuando conocen a Marla Singer, una mujer misteriosa que se convierte en el objeto de deseo de ambos." },
            new Pelicula { PeliculaId = 8, Titulo = "Inception", Sinopsis = "Dom Cobb es un ladrón de sueños que se dedica a robar secretos de la mente de las personas mientras duermen. Cuando se le ofrece la oportunidad de redimirse a cambio de una última misión, Cobb acepta el desafío de implantar una idea en la mente de un empresario rival. Sin embargo, la misión se complica cuando Cobb se enfrenta a sus propios demonios y a los secretos de su pasado." },
            new Pelicula { PeliculaId = 9, Titulo = "Star Wars Episodio V: El imperio contraataca", Sinopsis = "Después de la destrucción de la Estrella de la Muerte, la Alianza Rebelde se ha refugiado en el planeta Hoth. Mientras tanto, Darth Vader ha puesto en marcha un plan para capturar a Luke Skywalker y convertirlo en un Sith. Luke, Leia, Han Solo y Chewbacca se ven obligados a huir de Hoth y buscar refugio en la ciudad de las nubes, donde se enfrentarán a un enemigo inesperado." },
            new Pelicula { PeliculaId = 10, Titulo = "Matrix", Sinopsis = "Thomas Anderson es un programador de software que lleva una doble vida como hacker informático conocido como Neo. Cuando es contactado por Morfeo, un misterioso líder de la resistencia, Neo descubre que el mundo en el que vive es una simulación creada por máquinas inteligentes. Morfeo le ofrece la oportunidad de unirse a la resistencia y luchar contra las máquinas, pero Neo deberá enfrentarse a sus propios miedos y dudas para convertirse en el Elegido." },
            new Pelicula { PeliculaId = 11, Titulo = "Interestelar", Sinopsis = "En un futuro distópico, la Tierra se está muriendo debido a la falta de recursos naturales. Un grupo de astronautas es enviado en una misión espacial para encontrar un nuevo planeta habitable para la humanidad. Sin embargo, la misión se complica cuando los astronautas se enfrentan a peligros desconocidos y a la traición de uno de sus miembros." },
            new Pelicula { PeliculaId = 12, Titulo = "Dune: Parte dos", Sinopsis = "La segunda parte de la adaptación de la novela de ciencia ficción de Frank Herbert. Después de la traición de su tío, Paul Atreides se convierte en el líder de la tribu Fremen y se embarca en una misión para liberar el planeta Arrakis del control de la Casa Harkonnen. Sin embargo, Paul descubre que su destino está ligado a un antiguo profeta y a una misteriosa profecía que podría cambiar el curso de la historia." },
            new Pelicula { PeliculaId = 13, Titulo = "Terminator 2: El juicio final", Sinopsis = "Después de la destrucción del T-800 en Los Ángeles, Sarah Connor y su hijo John se han escondido en México para evitar ser capturados por Skynet. Sin embargo, un nuevo Terminator, el T-1000, es enviado desde el futuro para eliminar a John. Sarah y John se unen a un T-800 reprogramado para protegerlos y juntos intentan detener el juicio final y salvar a la humanidad de la extinción." },
            new Pelicula { PeliculaId = 14, Titulo = "Volver al futuro", Sinopsis = "Marty McFly es un adolescente de los años 80 que viaja en el tiempo a 1955 en un DeLorean modificado por el Dr. Emmett Brown. Allí, Marty conoce a sus padres antes de que se conozcan y cambia el curso de la historia. Ahora, Marty debe encontrar una forma de arreglar las cosas y regresar a su tiempo antes de que sea demasiado tarde." },
            new Pelicula { PeliculaId = 15, Titulo = "Barbie", Sinopsis = "Vivir en Barbie Land es el sueño de muchas niñas. Barbie es una muñeca de plástico que ha sido un icono de la moda y la belleza desde su creación en 1959. Con su cabello rubio, su sonrisa perfecta y su guardarropa interminable, Barbie ha inspirado a generaciones de niñas a soñar en grande y a creer en sí mismas." }
        );

        builder.HasMany(c => c.Categorias).WithMany(c => c.Peliculas).UsingEntity(j => j.HasData(
            new { PeliculasPeliculaId = 1, CategoriasCategoriaId = 6 },
            new { PeliculasPeliculaId = 2, CategoriasCategoriaId = 6 },
            new { PeliculasPeliculaId = 2, CategoriasCategoriaId = 8 },
            new { PeliculasPeliculaId = 3, CategoriasCategoriaId = 1 },
            new { PeliculasPeliculaId = 3, CategoriasCategoriaId = 2 },
            new { PeliculasPeliculaId = 3, CategoriasCategoriaId = 8 },
            new { PeliculasPeliculaId = 4, CategoriasCategoriaId = 8 },
            new { PeliculasPeliculaId = 5, CategoriasCategoriaId = 6 },
            new { PeliculasPeliculaId = 5, CategoriasCategoriaId = 8 },
            new { PeliculasPeliculaId = 6, CategoriasCategoriaId = 8 },
            new { PeliculasPeliculaId = 6, CategoriasCategoriaId = 15 },
            new { PeliculasPeliculaId = 7, CategoriasCategoriaId = 8 },
            new { PeliculasPeliculaId = 8, CategoriasCategoriaId = 1 },
            new { PeliculasPeliculaId = 8, CategoriasCategoriaId = 2 },
            new { PeliculasPeliculaId = 9, CategoriasCategoriaId = 1 },
            new { PeliculasPeliculaId = 9, CategoriasCategoriaId = 2 },
            new { PeliculasPeliculaId = 9, CategoriasCategoriaId = 10 },
            new { PeliculasPeliculaId = 10, CategoriasCategoriaId = 1 },
            new { PeliculasPeliculaId = 10, CategoriasCategoriaId = 4 },
            new { PeliculasPeliculaId = 11, CategoriasCategoriaId = 1 },
            new { PeliculasPeliculaId = 11, CategoriasCategoriaId = 2 },
            new { PeliculasPeliculaId = 11, CategoriasCategoriaId = 4 },
            new { PeliculasPeliculaId = 12, CategoriasCategoriaId = 1 },
            new { PeliculasPeliculaId = 12, CategoriasCategoriaId = 2 },
            new { PeliculasPeliculaId = 12, CategoriasCategoriaId = 8 },
            new { PeliculasPeliculaId = 13, CategoriasCategoriaId = 1 },
            new { PeliculasPeliculaId = 13, CategoriasCategoriaId = 2 },
            new { PeliculasPeliculaId = 13, CategoriasCategoriaId = 4 },
            new { PeliculasPeliculaId = 14, CategoriasCategoriaId = 2 },
            new { PeliculasPeliculaId = 14, CategoriasCategoriaId = 4 },
            new { PeliculasPeliculaId = 14, CategoriasCategoriaId = 5 },
            new { PeliculasPeliculaId = 15, CategoriasCategoriaId = 2 },
            new { PeliculasPeliculaId = 15, CategoriasCategoriaId = 5 },
            new { PeliculasPeliculaId = 15, CategoriasCategoriaId = 10 }
        ));
    }
} 