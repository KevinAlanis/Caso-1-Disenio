# DUA streamliner
CURSO: IC6821 Diseño de software

GRUPO: 02

Caso: #1 DUA Streamliner
PROFESOR: Rodrigo Nuñez Nuñez


**Author**: KEVIN ALANIS PINEDA - 2018083622

# Intelligent System for the Automated Generation of DUA
Problem
The Documento Único Aduanero (DUA) is the official document used to declare goods to customs authorities in Costa Rica. It consolidates critical information about the importer or exporter, the goods, transportation, values, taxes, and supporting documentation. Preparing it correctly is essential to avoid delays, fines, or rejected import/export processes. However, creating a DUA requires interpreting many source documents—such as invoices, packing lists, certificates of origin, and transport documents—which often come in different formats and structures, making the manual process slow and error-prone.

Proposed Solution
The project proposes designing an automated system that simplifies the preparation of the DUA. The system will extract and interpret relevant information from multiple heterogeneous documents (such as PDFs, Excel files, Word documents, and scanned images) and use that information to pre-fill the required fields of the DUA. This automation aims to reduce manual work and allow customs agents to focus mainly on verifying the information rather than entering it from scratch.

Expected Results
As a result, the system will significantly reduce the time required to prepare a DUA and decrease the likelihood of human errors during the process. Customs agents will be able to review and validate pre-filled declarations more efficiently, improving the speed and reliability of import and export procedures. Ultimately, the solution is expected to streamline customs documentation workflows and increase operational efficiency for companies involved in international trade.

# 1.Frontend design

## 1.1 Technology stack:
- Application type: Web application
- Web Framework: ReactJS v19.2
- NodeJS v20
- TypeScript v5.9.3
- Unit Testing: Jest v30.2.0
- Zod v4.3.6 to data validation
- Prettier 3.8.1
- Eslint v10.0.2
- Integration testing: Playwrite v1.58.2
- Cloud service: Azure cloud services
- Hosted by Azure App Service 
- Code repositories AzureDevOps
- Automated code task by Husky v9.1.7
- CI CD Azure Pipelines
- Environments: development, stage, qa and production
- Environments: deployment Azure DevOPs Environments
- Observability: Application Insights SDK


## 1.2 UX UI analysis
### Core Busieness process
Describir paso a paso lo que sucede en cada pantalla en terminos de acciones, no hablar de botones, ni listas ni ningún componente visual, solo acciones de usuario y el resultado de cada acción.

### login
1. El usuario ingresa el log in y password y el one time token.
2. Al intentar loguearse si falla,m se le presenta un mensaje al user and pass invalido
3. Si es succes ...

###  Congifurar el generador

### Monitoreo del avance

### Obtenición del resultado

### Log out

### Wireframes
Con los pasos anteriores le pido a una AI que me genere los screens y los pego aquí con un título, descripción y la imagen empotrada.
Login screen. The user can login int his account using the microsoft authentication screen ![Login](/media/login.jpg)

  - Seleccionar el Folder
  - Seleccionar la plantilla de DUA
  - Cómo monitero el avance del proceso
  - Cómo se ve el resultado final


### UX test results
- escoger alguna app para ejecutar UX test usando esos wireframes (Maze?)
- el test se le aplica en forma remota compartiendo un URL, a 3 estudiantes o amigos.
- eso va a generar un reporte de resultados
- crear un markdown table con los resultados
- evidencias
![Pablo mi amigod](/media/testdejuan.jpg)
![mario mi amigod](/media/testdemario.jpg)
![maria mi amigod](/media/testdemaria.jpg)

- heatmap
![DUA streamliner heatmap](/media/heatmap.jpg)





##1.3 Component design strategy: 
Defines the technique and principles of frontend component design, how component reuse is achieved, how styles are centralized, branding, internationalization and responsiveness.

##1.4 Security
Technologies, techniques and classes with their respective location in the project structure responsible for authentication and authorization of permissions and sessions. 

##1.5 Layered design
design and explanation of the application’s various layers in the frontend. 

##1.6 Design patterns
Design of classes with their respective location in the project structure, where it is necessary to apply object-oriented design patterns, such as: security, UI refresh, receiving notifications, state storage, api calls, asynchronous operations, invalidation of sessions, scheduling by events, creation of objects. 

##1.7 a folder in /src 
which contains the scaffold of the project, which is generated from the entire specification of points 1.1 to 1.6. 


WEB facil acceso: React o Angular?mejor soporte pero no tan caro/robusto y con suficientes ingenieros que lo manejen...

#Backend desing

#Data design
