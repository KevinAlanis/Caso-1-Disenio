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
The core process of the system is to allow an authenticated user to set up a DUA generation run, deliver necessary source documents, supervise the automated analysis and finally review and download the pre-populated result. The system does not replace final human validation, but rather automates extraction and prellening to reduce time and operational errors.

The core business flow would be:

1. The user accesses the system using secure authentication.
2. The user starts a new DUA generation run.
3. The user indicates the location of the source documents that will be processed.
4. The user selects or confirms the official SAD template to be used as a basis.
5. The system validates that there are sufficient inputs and that the process can be executed.
6. The system analyzes documents, extracts relevant information and maps it to the SAD format.
7. The user monitors the overall progress of processing and checks for any warnings or inconsistencies.
8. The system generates the final prefile.
9. The user looks up the result, checks the confidence level of the data and gets the generated document.
10. The user can log out at the end.

### Login
Objective

Allow only authorized users to access the system through secure authentication.

User actions and system results

1. The user enters their login credentials and single-use authentication code.
2. The system validates that credentials match an active and authorized account.
3. If validation fails, the system reports that the credentials or token are invalid and allows for a retry.
4. If validation is successful, the system grants access to the platform and directs the user to the main workspace.
5. If the user exceeds several consecutive failed attempts, the system may temporarily block access or require further validation.

### Home / Initial Dashboard
Objective

Allow the user to initiate a new generation of DUA or continue with a previous execution.

User actions and system results

1. The user accesses the main system space after authenticating.
2. The system presents the overall status of recent executions and available options according to user role.
3. The user decides to start a new run or review an earlier run.
4. If you start a new run, the system directs it to the generator configuration flow.
5. If you select a prerun, the system displays its current state or final result.

### Configure the generator
Objective

Allow the user to define the inputs needed to execute the automatic generation process of DUA.

User actions and system results

1. The user starts a new generation run.
2. The user indicates the location of the set of documents that will be used as a source of information.
3. The system verifies that the specified location is accessible and contains files compatible with the process.
4. The user selects the official SAD template that will be used for the sample.
5. The system validates that the selected template matches a version supported by the solution.
6. The user confirms that the information provided is correct and requests to start processing.
7. Before starting, the system validates that there are sufficient documents, that the template is valid and that no mandatory parameters are missing.
8. If validation fails, the system informs you which condition prevents you from continuing.
9. If the validation is successful, the system registers the new execution and starts automatic processing.

Special cases you should consider

- The folder does not exist.
- The folder is empty.
- Corrupt files or unsupported formats exist.
- The selected template does not correspond to the current version.
- The user tries to run the process without sufficient supporting documents.

### Monitoring progress
Objective

Allow the user to know the status of processing and be able to identify whether the execution is progressing correctly or requires attention.

User actions and system results

1. Once the execution is started, the user views the progress of the processing.
2. The system reports on the overall status of execution and the current stage of the process.
3. The user can check if the documents have already been read, if data extraction has been completed and if mapping to DUA is in progress.
4. If the system detects inconsistencies, ambiguities or insufficient information, it communicates them to the user as processing warnings.
5. If a critical error occurs, the system reports that execution cannot continue and indicates the overall cause of the issue.
6. If processing is successful, the system updates the completed state and enables access to the final result.

### Outcome
Objective

Allow the user to view the generated DUA, understand the confidence level of the prellened and obtain the file for review and later use.

User actions and system results

1. When the processing is finished, the user accesses the execution result.
2. The system presents the generated document along with the process traceability information.
3. The user reviews the result to identify fields with high, medium, or low confidence.
4. The system makes it possible to distinguish which parts of the document require more careful user validation.
5. The user obtains the prefilled file for review, correction or later use within the customs flow.
6. The system retains the execution-related result for future reference or audit.

### History of executions or previous results
Allow the user to view past runs and retrieve previous results or statuses.

User actions and system results

1. The user looks up previous runs.
2. The system displays the executions associated with your account or work context.
3. User selects a previous run to check its status or outcome.
4. If the execution was successful, the system allows access to the generated document again.
5. If the execution failed, the system reports the status and recorded cause of the failure.

### Error handling / failed execution

### Log out
Objective

Allow the user to log out safely.

User actions and system results

1. The user requests to end their session.
2. The system invalidates the active session and removes authenticated access to the system.
3. The user is redirected out of the protected area of the application.
4. If the user tries to access protected information again, the system requests authentication again.


### Wireframes

1. Login Microsoft SSO

Purpose

Allow users to securely authenticate into the DUA Streamliner platform using Microsoft Single Sign-On (SSO), ensuring that only authorized organizational accounts can access the system.

Description

The screen presents the Microsoft authentication interface that allows users to sign in with their organizational credentials. The authentication process may include identity verification and multi-factor authentication. Once the authentication is successful, the system establishes a secure session and redirects the user to the main workspace of the application. If authentication fails, the system informs the user and allows them to retry the sign-in process.

![Log in](/media/login.png)

2. Home Dashboard

Purpose

Provide users with a central workspace where they can start a new DUA generation process or review the status and results of previous executions.

Description

The dashboard displays an overview of the user’s recent DUA generation activities and provides quick access to the main system actions. From this screen, users can initiate a new DUA generation run or access previously executed processes to review their status or retrieve generated results. The dashboard serves as the primary entry point for managing document processing workflows within the platform.

![Home Page/Dashboard](/media/Dashboard.png)

3. Select Document Folder
Purpose

Allow the user to indicate the location containing the source documents that will be analyzed for the DUA generation process.

Description

The screen allows the user to specify the folder containing the import/export documentation. The system validates that the folder exists and contains readable files.

![Select Document Folder](/media/selectFolder.png)

4. Select DUA Template
Purpose

Allow the user to select the official DUA template that will be used as the base structure for the generated declaration.

Description

The user confirms the official template version supported by the system.

![Select DUA Template](/media/selectDUATemplate.png)

5. Processing Monitoring Screen
Purpose

Allow the user to observe the progress of the automated document processing and detect warnings or errors.

Description

The screen displays the execution progress and the stage of the processing pipeline.

![Processing Monitoring Screen](/media/Monitoring.png)

6. Generated Result Screen
Purpose

Allow the user to review the generated DUA and retrieve the document for validation.

Description

The screen presents the generated document along with confidence indicators for the extracted data.

![Outcome](/media/Outcome.png)


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
