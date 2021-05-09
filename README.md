# Music Playlist Application
Mobile CRUD Music Playlist Application

## Table of Contents
- [Project Overview](#project-overview)
- [Project Management](#project-management)
  * [Project Timeline](#project-timeline)
  * [Trello Board](#trello-board)
  * [Risk Assessment Matrix](#risk-assessment-matrix)
- [Databases](#databases)
- [Development](#development)
- [Testing](#testing)
- [Deployment](#deployment)
- [Further Analysis](#further-analysis)
- [Licensing and Copyright](#licensing-and-copyright)
 - [Contributors](#contributors)
 - [Acknowledgements](#acknowledgements)

## Project Overview
The purpose of this project is to create a functional Create, Read, Update, Delete (CRUD) music playlist application by using appropriate tools, technologies and methodologies. Inclusive of effective project management practices, utilising a relational MySQL database with two tables in it, C# and ASP.net full-stack development, testing functions and creating a test report and using Azure DevOps to create a pipeline to deploy the application to an app service.

## Project Management
This section will discuss the timeline, trello board, tasks and risks for the project.

###  Project Timeline
<img width="513" alt="timeline" src="https://user-images.githubusercontent.com/82107035/117551158-39d94a00-b03c-11eb-8de2-68038de9ec16.PNG">


###  Trello Board
<img width="960" alt="trelloboard" src="https://user-images.githubusercontent.com/82107035/117551782-d05b3a80-b03f-11eb-8779-d9acef36adae.PNG">

Every use case is inclusive of playlists and songs.

<img width="305" alt="use case" src="https://user-images.githubusercontent.com/82107035/117555019-782e3380-b053-11eb-8ae7-62f8b42e1fde.PNG">


### Risk Assessment Matrix
<img width="563" alt="Risk Assessment" src="https://user-images.githubusercontent.com/82107035/116565920-31776580-a8fe-11eb-9762-5782e0309026.PNG">

## Databases
Two tables – artist, album
ArtistID and songID are primary keys
Created two tables within a database to persistently store data for the project.

<img width="379" alt="databasearchitecture" src="https://user-images.githubusercontent.com/82107035/117578191-15857800-b0e5-11eb-8f8e-e1be8ee5e3a4.PNG">

Above shows the database architecture that will be used.


View Tables in Playlist Database.

<img width="202" alt="sqlshowtablesindb" src="https://user-images.githubusercontent.com/82107035/117554707-37351f80-b051-11eb-9c15-fc8e7b69a729.PNG">

View everything within the playlist table.

<img width="689" alt="selectallfromplaylists" src="https://user-images.githubusercontent.com/82107035/117554723-56cc4800-b051-11eb-8575-8ae09c4752b1.PNG">

View everything within the songs table.

<img width="651" alt="selectallfromsongs" src="https://user-images.githubusercontent.com/82107035/117554731-5fbd1980-b051-11eb-86cf-413ab043f267.PNG">


## Development
The development of the application was done using C# and ASP.Net. Below are screenshots of the final application.

<img width="685" alt="viewplaylist" src="https://user-images.githubusercontent.com/82107035/117554638-e1f90e00-b050-11eb-9c9f-ed766a4a59bf.PNG">

<img width="722" alt="viewsongs" src="https://user-images.githubusercontent.com/82107035/117554660-fb9a5580-b050-11eb-8edc-207d1ab7403c.PNG">


## Testing
<img width="213" alt="tests" src="https://user-images.githubusercontent.com/82107035/117554760-9d21a700-b051-11eb-81ab-92e548e4586d.PNG">

Testing Analysis:



Write tests for your application to prove that it can access other systems and connect to them, e.g. a database
Create an analysis of what should be tested and why, what is out of scope and why  (discuss in detail) and provide a summary of overall results 
Instructions on how to write integration testing, report must include the integration tests
Utilise a broad range of tests
Software should be tested in all areas with best practices and refactoring adhered and implemented throughout the project

## Deployment
This app was deployed to Azure App Service
<img width="960" alt="appservice" src="https://user-images.githubusercontent.com/82107035/117578669-4666ac80-b0e7-11eb-94f7-7ea0c0168a0f.PNG">

<img width="671" alt="appconnectiontoazuredb" src="https://user-images.githubusercontent.com/82107035/117578664-44045280-b0e7-11eb-94fa-8b055caee0f8.PNG">



## Further Analysis
Known Issues: 



Overall Risk Analysis:


Future Implementation:
Creating a yaml pipeline

## Licensing and Copyright
© Ezra Turner, QA Limited, Avanade

## Contributors
- Ezra Turner <ezra.turner@avanade.com>

## Acknowledgements
- Ben Hesketh
- Dara Oladapo
- Victoria Sacre
- Nick Pribyl
- Tam Edsel
