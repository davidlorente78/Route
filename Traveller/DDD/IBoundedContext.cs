//using System;
//using System.Collections.Generic;
//using System.Diagnostics.Metrics;
//using System.Linq;
//using System.Runtime.ConstrainedExecution;
//using System.Security.Principal;
//using System.Text;
//using System.Threading.Tasks;

namespace DDD;
public interface IBoundedContext
{
    //    Bounded Context Principal: Planificación de Rutas

    //Entidades:
    //Country: Representa países.
    //Agregado Principal:
    //No se especifica un agregado principal explícito, pero Country podría ser considerado como un agregado raíz.
    //Bounded Context de Aviación

    //Entidades:
    //Airport: Representa aeropuertos, con relación a Destination.
    //MainRoute: Representa rutas aéreas, conectando destinos.
    //Agregado Principal:
    //Airport podría ser considerado el agregado principal, ya que tiene relaciones con MainRoute y Destination.
    
    //Bounded Context de Migracion

    //Entidades:
    //BorderCrossing: Representa puntos de cruce de fronteras con relación a dos instancias de Destination.
    //Visa: Representa requisitos de visado.
    //Agregado Principal:
    //BorderCrossing podría ser considerado el agregado principal, ya que tiene relaciones con Destination y Visa.
    //Bounded Context de Railways

    //Entidades:
    //Country: Representa países (posiblemente utilizado para estaciones de tren).
    //Agregado Principal:
    //No se especifica un agregado principal explícito, pero Country podría ser considerado como un agregado raíz.
}




