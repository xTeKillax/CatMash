##CatMash - Farid TAZI
### Technologies

<p align="center">
  <img width="180" align="center" src="https://upload.wikimedia.org/wikipedia/commons/thumb/e/ee/.NET_Core_Logo.svg/512px-.NET_Core_Logo.svg.png"/><img width="180" align="center" src="https://res.cloudinary.com/startup-grind/image/upload/c_fill,dpr_2.0,f_auto,g_center,h_1080,q_100,w_1080/v1/sl0/v1/AUTH_d0619b05-07fc-49f0-8249-da585ea45ce5/docker/events/docker-round_0pFVLs8.png"/><img width="180" align="center" src="https://angularconferences.com/assets/img/confs/ngnepal.svg"/>
</p>


###Dépendances
- Newtonsoft JSON
- Swagger
- xUnit

###Architecture
Le projet se compose de services (actuellement un seul) qui se trouvent dans le dossier Services.
Le dossier Clients contiendra les différents clients possible (application angular, app android etc...).


###Services
####CatManagement
Il s'agit du premier service permettant d'interagir avec un chat.
Il implémente une architecture hexagonal qui intègre trois projets différents.

#####CatManagement.Infrastructure
On retrouve ici un l'implémentation d'une couche de donnée. L'unique implémentation est le InMemory DataAccess qui va lire un json et stocker tout en mémoire au sein du context. On implémente ensuite les interfaces du repository pour un "cat".
On utilise Autofac pour créer des modules pour chaque implémentation de DataAccess afin de pouvoir très facilement switcher de source de données.

#####CatManagement.Domain
Le domaine va contenir les différents objets (aggregate) qui vont être utilisé par le service. Pour des contraintes de temps, les interfaces du repository de chaque aggregate ont été mise ici.
Il existe également des valuesObject qui sont utiliser par les différents aggregate créer.
Pour des questions de simplicité et de temps, l'interface aggregate n'a pas été implémenté.

#####CatManagement.API
Il s'agit d'une simple API qui va venir consommer et exposer la data. Pour des questions de simplicité, je ne suis pas allé au bout du pattern CQRS en implémentant des queries. Ici, les controller utilisent directement les repositories.
Pour gagner du temps, j'ai tenté de m'affranchir d'une couche application mais ce fut un échec, il faudrait idéalement l'ajouter afin de supprimer la dépendance de l'API vers le Domain.
Le fichier Autofac.json permet de switcher entre les différentes implémentation mise en œuvre dans l'infrastructure.
Les controller sont répartir dans le dossier UseCases.

#####CatManagement.UnitTests
Ce projet implémente les tests unitaires pour le service CatManagement. On y trouve un dossier pour chaque couche du service (mais seulement le domain pour l'instant). Les tests sont réalisés à l'aide de xUnit.
Ce projet ne couvrant que les tests unitaire, il faudrait ajouter un projet pour les tests fonctionnels.  Une bonne pratique en SCRUM est d'implémenter SpecFlow pour faciliter les tests auto qui sont rédigé dans les US sous forme de Given When Then par exemple.

###Clients
####AngularApp
Il s'agit de la partie frontend sous Angular 7 qui requete le service **CatManagement**.
Ce projet est un placeholder et n'est pas complété.
Attention, sur ce projet il n'y a pas d'API Gateway mais normalement, le frontend ne devrait connaître que l'API Gateway. 

###Run l'application
Avoir docker d'installer, appuyer sur F5 ✨
- Swagger: http://localhost:5201/swagger/index.html
- Test de l'api CatManagement: http://localhost:5201/api/ladder
- HealthCheck: http://localhost:5201/hc

###TODO (dans le désordre)
- [ ] Application Layer
- [ ] Aggregate pattern
- [ ] MediatR implementation pour le command pattern
- [ ] Bus d'evenement (Rabbitmq par exemple)
- [ ] API Gateway
- [ ] Link frontend to backend
- [ ] Add frontend dockerization
- [ ] Finish CQRS (with queries and command pattern)
- [ ] Completer les test unitaire
- [ ] Créer les tests fonctionnels
- [ ] Liker des chats 🙄