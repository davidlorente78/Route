using Domain.Repositories;

namespace RouteDataManager.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        ICountryRepository Countries { get;  }
        IDestinationRepository Destinations { get;  }
        IFrontierRepository Frontiers { get; }
        int Complete();
    }
}


//Unit Of Work Pattern
//Unit of Work Pattern is a design pattern with which you can expose various respostiories in our application. It has very similar properties of dbContext, just that Unit of Work is not coupled to any framework like dbContext to Entity Framework Core.

//Till now, we have built a couple of repositories. We can easily inject these repositories to the constructor of the Services classes and access data. This is quite easy when you have just 2 or 3 repository objects involved. What happens when there are quite more than 3 repositories. It would not be practical to keep adding new injections every now and then. Inorder to wrap all the Repositories to a Single Object, we use Unit Of Work.

//Unit of Work is responsible for exposing the available Repositories and to Commit Changes to the DataSource ensuring a full transaction, without loss of data.

//The other major advantage is that, multiple repository objects will have different instances of dbcontext within them. This can lead to data leaks in complex cases.

//Let’s say that you have a requirement to insert a new Developer and a new Project within the same transaction. What happens when the new Developer get’s inserted but the Project Repository fails for some reason. In real-world scenarios, this is quite fatal. We will need to ensure that both the repositories work well, before commiting any change to the database. This is exactly why we decided to not include SaveChanges in any of the repostories. Clear?

//Rather, the SaveChanges will be available in the UnitOfWork Class. You will get a better idea once you see the impelemntation.

//Let’s get started with the IUnitOfWork. Create a new Interface in the domain Project, Interfaces/IUnitOfWork