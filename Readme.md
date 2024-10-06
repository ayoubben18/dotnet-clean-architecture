# This is a simple example of a clean architecture in .NET

## Architecture

This app will have 4 layers:

- API Layer
- Application Layer
- Domain Layer
- Persistence Layer

### API Layer

This layer is responsible for handling the HTTP requests and responses.
It will be the entry point of our application.

### Application Layer

This layer will contain the business logic of our application.
It will be responsible for coordinating the actions between the API layer and the domain layer.
It will be using the mediator pattern to send the command and queries to the domain layer.

### Domain Layer

This layer will contain the business rules of our application.
It will be the only layer that will be aware of the persistence layer.
It will contain the entities and the repositories interfaces.

### Persistence Layer

This layer will contain the implementation of the repositories.
It will be the only layer that will be aware of the database.

## CQRS

Command Query Responsibility Segregation

CQRS : Concerned with the flow of the data through the system.

#### Command

Does something - modify the state - Do not return any value
(Create and entry, Update an Activity, Delete an Activity)

#### Query

Answer a question - read the state - return a value

In a single database, it's hard to see the benefit of CQRS.

API -> Command -> Domain -> Persistence -> DB
DB -> Data Access -> Query -> API

We can see more of it's value in a multi db architecture

Like one for search and caching which will always be on read.
And one for the write operation which will be own main reference.

Having an Eventual consistency will optimize the read speed of our application.
Lead by exmaple: decomposing a query that requires multiple joins to retrieve data in a relational database,
to a no sql object and store in a database like mongo or redis.
This will simplify the query logic and improve the read performance of our application.

### Goals

- Make the controllers as thin as possible.
- Use dependency injection to inject the services into the controllers.
