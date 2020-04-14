# CompareIT is a software service providing its users with an online price comparison for electronic goods.
The system was designed based on a three-tier
architecture. Through these tiers, the logical separation between the presentation layer,
business logic and data layer was designed. The most efficient technical choices for the
implementation of these layers were selected. The user interface layer was deployed
using Blazor technology. Following the second tier was deployed through C#
development of business logic. Lastly, the data layer was deployed through PostgreSQL
as an optimal RDBMS. Furthermore, the integrity and validity of layers connectivity were
facilitated by the developed rest web services and TCP connection. Finally, the
functionality of the entire system was tested through various test methods to ensure
functionality as defined by the project statement of work.
CompareIT was conducted as a semester project in a group. It is using both a google public API and a fake API implemeneted by the group.
The system is using TCP connection between the second and the third tiers and I worked on this part to enable the system to 
communicate and send data between Java and C#. I was responsible for the data tier as well as design and implementing the database. 
The data persistence is designed based on Adapter desgin pattern. I also used JUnit for testing the database.
CompareIT is not a fully functional application



