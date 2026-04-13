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
- UX Test with Maze + Figma
- Average % of clicks outside maze hotspots 36.4%
- Average duration 165.9s
- Users 5 responses

- Markdown of results

| Path | Users | Misclick rate | Avg. duration |
| -------- | -------- | -------- | -------- |
| 1 | 2 | 58.3% | 70.3s |
| 2 | 1 | 41.7% | 167.4s |
| 3 | 1 | 0.0% | 238.2s |
| 4 | 1 | 0.0% | 283.1s |

- Evidence of navigational flow.
![Flow 1 to 6](/media/Flow1.png)
![Flow 7 to 12](/media/Flow2.png)
![Flow 13 to 18](/media/Flow3.png)

- Heatmaps Path 1
  
![Heatmap1](/media/P1.1.jpg)
![Heatmap1.2](/media/P1.2.jpg)
![Heatmap1.3](/media/P1.3.jpg)
![Heatmap1.4](/media/P1.4.jpg)
![Heatmap1.5](/media/P1.5.jpg)

- Heatmaps Path 2
  
![Heatmap2](/media/P2.1.jpg)
![Heatmap2.2](/media/P2.2.jpg)
![Heatmap2.3](/media/P2.3.jpg)
![Heatmap2.4](/media/P2.4.jpg)
![Heatmap2.5](/media/P2.5.jpg)
![Heatmap2.6](/media/P2.6.jpg)
![Heatmap2.7](/media/P2.7.jpg)
![Heatmap2.8](/media/P2.8.jpg)
![Heatmap2.9](/media/P2.9.jpg)
![Heatmap2.10](/media/P2.10.jpg)
![Heatmap2.11](/media/P2.11.jpg)

- Heatmaps Path 3
  
![Heatmap3](/media/P3.1.jpg)
![Heatmap3.2](/media/P3.2.jpg)
![Heatmap3.3](/media/P3.3.jpg)
![Heatmap3.4](/media/P3.4.jpg)
![Heatmap3.5](/media/P3.5.jpg)
![Heatmap3.6](/media/P3.6.jpg)
![Heatmap3.7](/media/P3.7.jpg)
![Heatmap3.8](/media/P3.8.jpg)
![Heatmap3.9](/media/P3.9.jpg)
![Heatmap3.10](/media/P3.10.jpg)
![Heatmap3.11](/media/P3.11.jpg)

- Heatmaps Path 4
  
![Heatmap4](/media/P4.1.jpg)
![Heatmap4.2](/media/P4.2.jpg)
![Heatmap4.3](/media/P4.3.jpg)
![Heatmap4.4](/media/P4.4.jpg)
![Heatmap4.5](/media/P4.5.jpg)
![Heatmap4.6](/media/P4.6.jpg)
![Heatmap4.7](/media/P4.7.jpg)
![Heatmap4.8](/media/P4.8.jpg)
![Heatmap4.9](/media/P4.9.jpg)
![Heatmap4.10](/media/P4.10.jpg)
![Heatmap4.11](/media/P4.11.jpg)
![Heatmap4.12](/media/P4.12.jpg)
![Heatmap4.13](/media/P4.13.jpg)
![Heatmap4.14](/media/P4.14.jpg)
![Heatmap4.15](/media/P4.15.jpg)
![Heatmap4.16](/media/P4.16.jpg)
![Heatmap4.17](/media/P4.17.jpg)

## 1.3 Component design strategy: 
### Strategy Implementation

- Name of the strategy
Centralized React Component Design System using MUI + centralized i18n layer

- Reutilization by:
Reusable React components organized within a shared UI component library. Common interface elements such as dialogs, forms, input fields, tables, and layout structures will be implemented once and reused throughout the system. Styling and visual rules will be managed through a centralized MUI theme configuration to ensure consistency across all application screens.

- Internationalization by:
A centralized internationalization layer integrated with the frontend using a dedicated localization framework such as react-i18next. Text content, labels, validation messages, and locale-sensitive values (dates, numbers, currencies) will be managed in external language resource files, allowing the interface language to be controlled independently from the application logic.

- Responsiveness by:
Responsive layout design implemented through MUI’s breakpoint system and flexible layout utilities. The design system will define consistent layout patterns that adapt to multiple screen sizes including desktops, tablets, and mobile devices. Responsive behavior will be handled at the component and theme level to ensure uniform behavior across the application.

## 1.4 Security
### Autenticación

- Microsoft Entra ID
- Autenticación del servicio de aplicaciones de Azure (autenticación fácil)
- OpenID Connect / OAuth 2.0
- MFA obligatorio
- habilitado SSO

### Recommended base option
- Factor 1: Microsoft Entra corporate account
- Factor 2: Microsoft Authenticator push notification
- Authentication model: Federated authentication
- Sign-in experience: Single Sign-On (SSO)
- Security strengthening: Multi-Factor Authentication (MFA)
- Identity Provider / Credential Server: Microsoft Entra ID
- Authentication service integration: Azure App Service Authentication (Easy Auth)
- Authentication session model: Managed by Microsoft Entra ID and Azure App Service Authentication
- Application session/cache: Optional, using Azure Managed Redis only for transient non-authentication state

### Cross-cutting security by layer

### Frontend
Responsible for:
- initiating Microsoft login
- using an already authenticated identity
- hiding or displaying features based on claims/roles
- visually signaling session expiration
- not storing secrets
### Technologies
- React
- TypeScript
- Microsoft login via App Service Authentication
- Route guards
- RBAC-based UI guards

### Backend
Responsibilities:
- validate incoming identities
- validate roles and permissions
- enforce policies
- log audit information
- control access to endpoints and resources
### Technologies
- Node.js
- TypeScript
- Azure App Service authentication headers / token context
- Authorization middleware
- RBAC + policies

### Data
Responsibilities:
- protecting secrets
- encrypting sensitive data
- controlling access via managed identities
- auditing access
### Recommended technologies
- Azure Key Vault for secrets, keys, and certificates
- Managed Identity to allow App Service to access secrets without embedded credentials
- encryption at rest and access control via Azure RBAC

### Third parties
Responsible for:
- secure integration with third-party providers
- storing credentials outside the code
- using the principle of least privilege
- logging calls and errors
### Recommendation
All third-party integrations must include:
- secrets stored in Key Vault
- access via Managed Identity where applicable
- timeouts, controlled retries, and logging
- separation of credentials by environment

### Azure RBAC
1. Admin: Full control over the system and operational settings.

2. Support: Technical diagnostics, monitoring, and incident response, but without the ability to modify critical business data except in authorized cases.

3. Customer Service: Case tracking, execution monitoring, and end-user support, with limited editing access.

4. Customs Agent: Primary business user. Uploads documents, performs processing, reviews results, and obtains the generated DUA.}

### Core permissions
RUN_CREATE -> Create a new DUA generation run
RUN_VIEW -> View an existing run
RUN_CANCEL -> Cancel a running run
RUN_RETRY -> Retry a failed run
FOLDER_REGISTER -> Register or specify the location of source documents
FOLDER_VALIDATE -> Verify that the source documents exist and are processable
TEMPLATE_SELECT -> Select the official DUA template
TEMPLATE_VIEW -> View available template versions
DOCUMENT_UPLOAD -> Upload input documents to the system
DOCUMENT_VIEW -> View documents associated with a run
PROCESS_MONITOR -> Monitor processing progress
WARNING_VIEW -> View detected warnings or inconsistencies
RESULT_VIEW -> View the generated DUA
RESULT_DOWNLOAD -> Download the generated file
RESULT_REVIEW -> Mark the result as reviewed
HISTORY_VIEW -> View execution history
AUDIT_VIEW -> View logs or audit trails
USER_VIEW -> View users
USER_MANAGE -> Manage users and role assignments
ROLE_MANAGE -> Create or modify internal roles
SYSTEM_CONFIG -> Modify system parameters
SUPPORT_CASE_VIEW -> View incidents or support cases
SUPPORT_CASE_MANAGE -> Manage support cases
Example by role
Admin
Todos los permisos.

### Soporte técnico
RUN_VIEW
PROCESS_MONITOR
WARNING_VIEW
RESULT_VIEW
HISTORY_VIEW
AUDIT_VIEW
SUPPORT_CASE_VIEW
SUPPORT_CASE_MANAGE
### Servicio al cliente
RUN_VIEW
PROCESS_MONITOR
WARNING_VIEW
VISUALIZAR_RESULTADO
VISUALIZAR_HISTORIAL
VISUALIZAR_CASO_DE_SOPORTE
### Agente de aduanas
CREAR_PROCESO
VISUALIZAR_PROCESO
REINTENTAR_PROCESO
REGISTRAR_CARPETA
VALIDAR_CARPETA
SELECCIONAR_PLANTILLA
VISUALIZAR_PLANTILLA
DOCUMENT_UPLOAD
DOCUMENT_VIEW
PROCESS_MONITOR
WARNING_VIEW
RESULT_VIEW
RESULT_DOWNLOAD
RESULT_REVIEW
HISTORY_VIEW

### Possible ACLs
via email: authorized corporate domains only
via Entra group
via IP range: restrict administrative access to the corporate network or VPN

Service / Policy Module
PolicyRegistry
AuthorizationService
Suggested Policies
ExecutionOwnershipPolicy -> A user can only view/edit executions they created, except for support or admin
ResultDownloadPolicy -> Only download results if the execution completed successfully
TemplateVersionPolicy -> Only allow current templates
SupportRestrictedAccessPolicy -> Support can view, but not modify, the final result
CorporateNetworkPolicy -> Certain administrative operations are allowed only from permitted IP addresses or ranges
BusinessHoursAdminPolicy -> Optional for critical actions during defined hours

### Secure storage service: Azure Key Vault

This should be your official service for:
- sensitive environment variables
- secrets
- keys
- certificates
- third-party tokens
 
## 1.5 Layered design
```bash
src/
│
├── app/                         # Configuración global de la app
│   ├── App.tsx
│   ├── routes.tsx
│   ├── providers/              # Providers globales (Auth, Theme, i18n)
│   ├── store/                  # Estado global (Redux/Zustand si aplica)
│
├── features/                   # Módulos por dominio (feature-based)
│   ├── auth/
│   ├── dua-generation/
│   ├── monitoring/
│   ├── results/
│   ├── history/
│
├── pages/                      # Pantallas (composición de features)
│   ├── LoginPage.tsx
│   ├── DashboardPage.tsx
│   ├── GeneratorPage.tsx
│   ├── MonitoringPage.tsx
│   ├── ResultPage.tsx
│
├── components/                 # Componentes reutilizables (UI genérico)
│   ├── common/                 # Botones, inputs, modals
│   ├── layout/                 # Header, sidebar, containers
│   ├── feedback/               # loaders, alerts, notifications
│
├── services/                   # Comunicación externa (API calls)
│   ├── apiClient.ts
│   ├── duaService.ts
│   ├── authService.ts
│
├── security/                   # Autenticación y autorización
│   ├── auth/
│   ├── guards/
│   ├── permissions/
│
├── hooks/                      # Custom hooks reutilizables
│   ├── useAuth.ts
│   ├── usePermissions.ts
│   ├── useApi.ts
│
├── models/                     # Tipos y modelos (DTOs)
│   ├── DUA.ts
│   ├── User.ts
│
├── utils/                      # Funciones utilitarias
│   ├── formatters/
│   ├── validators/
│
├── i18n/                       # Internacionalización
│   ├── en.json
│   ├── es.json
│
├── styles/                     # Tema y estilos globales (MUI)
│   ├── theme.ts
│
├── assets/                     # Imágenes, íconos
│
└── index.tsx                   # Entry point
```

## 1.6 Design patterns
1. Security
Purpose
Handle authentication, authorization, session lifecycle, and role/permission resolution.
Project location
src/security/
src/security/auth/
src/security/session/
src/security/authorization/
Classes
AuthService

Location: src/security/auth/AuthService.ts
Responsibility: Handles sign-in, sign-out, retrieval of authenticated user information, and authentication state resolution from Azure App Service Authentication / Microsoft Entra ID.

Pattern: Facade

Provides a simplified interface to the authentication mechanism.
Hides token/session details from the rest of the application.
SessionManager

Location: src/security/session/SessionManager.ts
Responsibility: Manages client-side session lifecycle, session expiration detection, logout propagation, and invalid session handling.

Pattern: Singleton

Only one shared session manager should exist in the frontend.
Prevents duplicated session logic across pages.
AuthorizationService

Location: src/security/authorization/AuthorizationService.ts
Responsibility: Evaluates whether the current user has access to specific actions, pages, or features based on roles and permissions.

Pattern: Strategy

Different authorization strategies can be applied, such as role-based checks, permission-based checks, or policy-based checks.
PermissionPolicy

Location: src/security/authorization/policies/PermissionPolicy.ts
Responsibility: Defines rules to determine whether a specific permission is granted.

Pattern: Strategy

Allows different access rules to be plugged into the authorization flow.
RoleMapper

Location: src/security/authorization/RoleMapper.ts
Responsibility: Translates identity claims into internal application roles.

Pattern: Adapter

Adapts external identity provider claims into the app’s internal authorization model.

2. UI Refresh
Purpose
Trigger controlled UI updates when relevant business state changes.
Project location
src/ui/state/
src/ui/refresh/

Classes
UIRefreshManager

Location: src/ui/refresh/UIRefreshManager.ts
Responsibility: Coordinates explicit UI refresh requests after relevant actions such as completed processing, status changes, or session expiration.

Pattern: Observer
UI sections subscribe to relevant state changes.
Useful when multiple parts of the interface must react to one event.
ViewStateStore
Location: src/ui/state/ViewStateStore.ts
Responsibility: Holds shared transient UI state such as current execution status, loading flags, or visible warnings.
Pattern: Singleton
Centralized access point to common frontend view state.

3. Receiving Notifications
Purpose
Handle alerts, warnings, informational messages, and process completion notifications.
Project location
src/notifications/

Classes
NotificationService
Location: src/notifications/NotificationService.ts
Responsibility: Sends notifications to the UI when important system or user events occur.
Pattern: Observer
UI components subscribe to notification events.
Decouples message producers from message consumers.
NotificationFactory
Location: src/notifications/NotificationFactory.ts
Responsibility: Creates notification objects according to type, severity, and context.
Pattern: Factory Method
Standardizes creation of success, warning, error, and info notifications.
NotificationMessage
Location: src/notifications/models/NotificationMessage.ts
Responsibility: Represents the structure of a notification shown to the user.
Pattern: Domain model / value object

4. State Storage
Purpose
Provide centralized frontend state handling for user session, current execution, selected template, results, and monitoring data.
Project location
src/state/
src/state/stores/
Classes
AppStateStore

Location: src/state/stores/AppStateStore.ts
Responsibility: Maintains global application state shared across features.
Pattern: Singleton
One shared state container for app-wide data.
ExecutionStore
Location: src/state/stores/ExecutionStore.ts
Responsibility: Maintains state of the active DUA generation workflow.
Pattern: State
The execution can move between states such as draft, validating, processing, completed, failed.
UserSessionStore
Location: src/state/stores/UserSessionStore.ts
Responsibility: Stores authenticated user context and permission snapshot.
Pattern: Singleton

5. API Calls
Purpose
Centralize communication with backend endpoints and isolate HTTP concerns.
Project location
src/services/api/

Classes
ApiClient

Location: src/services/api/ApiClient.ts
Responsibility: Performs HTTP requests, standardizes headers, handles errors, and abstracts the transport mechanism.

Pattern: Facade

Exposes a simple interface for GET/POST/PUT/DELETE operations.
ExecutionApiService

Location: src/services/api/ExecutionApiService.ts
Responsibility: Handles API communication for DUA generation runs, monitoring, and results.

Pattern: Service Layer

Encapsulates business-specific API operations.
TemplateApiService

Location: src/services/api/TemplateApiService.ts
Responsibility: Retrieves and validates available DUA templates.

Pattern: Service Layer

AuthApiService

Location: src/services/api/AuthApiService.ts
Responsibility: Obtains authentication/session-related information from backend or platform endpoints.

Pattern: Service Layer

6. Asynchronous Operations
Purpose

Control polling, long-running operations, async status tracking, and retry logic.

Project location
src/async/
src/monitoring/

Classes
AsyncTaskManager

Location: src/async/AsyncTaskManager.ts
Responsibility: Coordinates asynchronous frontend operations, including polling and promise lifecycle tracking.

Pattern: Command

Each async task can be represented as an executable action.
PollingScheduler

Location: src/monitoring/PollingScheduler.ts
Responsibility: Repeatedly queries execution status until completion, failure, or cancellation.

Pattern: Strategy

Polling behavior may vary depending on interval, retry policy, or screen context.
RetryPolicy

Location: src/async/RetryPolicy.ts
Responsibility: Defines retry rules for transient failures in status retrieval or API communication.

Pattern: Strategy

7. Session Invalidation
Purpose

Ensure secure logout and response to invalid or expired sessions.

Project location
src/security/session/

Classes
SessionInvalidationHandler

Location: src/security/session/SessionInvalidationHandler.ts
Responsibility: Reacts to expired sessions, revoked access, or unauthorized responses, forcing logout and UI cleanup.

Pattern: Observer

Listens for invalid session events and triggers coordinated actions.
LogoutCommand

Location: src/security/session/LogoutCommand.ts
Responsibility: Encapsulates the logout process, including state cleanup and redirection.

Pattern: Command

Encapsulates the session termination action as a reusable operation.
8. Scheduling by Events
Purpose

Coordinate frontend reactions to domain events such as processing completion, warning generation, or session timeout.

Project location
src/events/

Classes
EventBus

Location: src/events/EventBus.ts
Responsibility: Publishes and distributes application events across independent modules.

Pattern: Observer / Publish-Subscribe

Suitable for decoupled event-driven UI behavior.
DomainEvent

Location: src/events/DomainEvent.ts
Responsibility: Base structure for typed frontend events.

Pattern: Base class / event model

ExecutionCompletedEvent

Location: src/events/execution/ExecutionCompletedEvent.ts
Responsibility: Represents the completion of a DUA generation run.

Pattern: Event object

WarningDetectedEvent

Location: src/events/execution/WarningDetectedEvent.ts
Responsibility: Represents that processing generated warnings requiring user attention.

Pattern: Event object

9. Creation of Objects
Purpose

Standardize creation of domain models and UI models from backend responses.

Project location
src/models/
src/factories/

Classes
ExecutionFactory

Location: src/factories/ExecutionFactory.ts
Responsibility: Creates Execution objects from backend DTOs.

Pattern: Factory Method

Prevents raw API data from being spread across the UI.
UserFactory

Location: src/factories/UserFactory.ts
Responsibility: Creates authenticated user objects from security claims.

Pattern: Factory Method

ResultFactory

Location: src/factories/ResultFactory.ts
Responsibility: Builds result models with confidence metadata and traceability information.

Pattern: Factory Method

```bash
src/
├── security/
│   ├── auth/
│   │   └── AuthService.ts
│   ├── session/
│   │   ├── SessionManager.ts
│   │   ├── SessionInvalidationHandler.ts
│   │   └── LogoutCommand.ts
│   └── authorization/
│       ├── AuthorizationService.ts
│       ├── RoleMapper.ts
│       └── policies/
│           └── PermissionPolicy.ts
│
├── notifications/
│   ├── NotificationService.ts
│   ├── NotificationFactory.ts
│   └── models/
│       └── NotificationMessage.ts
│
├── services/
│   └── api/
│       ├── ApiClient.ts
│       ├── ExecutionApiService.ts
│       ├── TemplateApiService.ts
│       └── AuthApiService.ts
│
├── state/
│   └── stores/
│       ├── AppStateStore.ts
│       ├── ExecutionStore.ts
│       └── UserSessionStore.ts
│
├── async/
│   ├── AsyncTaskManager.ts
│   └── RetryPolicy.ts
│
├── monitoring/
│   └── PollingScheduler.ts
│
├── events/
│   ├── EventBus.ts
│   ├── DomainEvent.ts
│   └── execution/
│       ├── ExecutionCompletedEvent.ts
│       └── WarningDetectedEvent.ts
│
├── factories/
│   ├── ExecutionFactory.ts
│   ├── UserFactory.ts
│   └── ResultFactory.ts
│
└── ui/
    ├── refresh/
    │   └── UIRefreshManager.ts
    └── state/
        └── ViewStateStore.ts
```
# Backend desing

## Technology stack

- API style: REST API
- Transport: HTTPS over TLS 1.2+
- API contract standard: OpenAPI 3.1
- API gateway: Azure API Management
- Hosting: Azure App Service
- Backend language: C#
- Framework: ASP.NET Core 8 Web API
- Repository model: Monorepo compartido con frontend
- Backend folder: duabusiness/
- Architecture style: Modular monolith
- Asynchronous operations: cola de trabajos + procesamiento desacoplado
- Notifications: Azure Notification Hubs para notificaciones hacia cliente
- No load balancer required: se mantiene así en el diseño base
- Storage complementario recomendado: Azure Blob Storage
- Database complementaria recomendada: Azure SQL Database

The backend will be implemented as a modular monolith within the shared monorepo, under the duabusiness/ folder. The system will expose a REST API over HTTPS, documented with OpenAPI 3.1, fronted by Azure API Management, and hosted on Azure App Service using ASP.NET Core 8 Web API. Asynchronous processing will be handled through internal background processing components and cloud messaging support, while user-facing notifications will use Azure Notification Hubs. This approach keeps operational complexity low while preserving clear module boundaries and future evolution paths.

## Security

- Authentication: Microsoft Entra ID
- Authentication integration: Azure App Service Authentication (Easy Auth)
- Authorization: RBAC + policy-based authorization
- Transport security: HTTPS mandatory, TLS 1.2+
- Secrets management: Azure Key Vault
- Managed access to secrets: Managed Identity
- Database encryption: AES-256 at rest
- Encryption in transit: TLS 1.2+ for API and DB connections
- Payload size limit (general): 25 MB default
- Payload exceptions: file upload endpoints up to 100 MB per request
- Rate limiting: via Azure API Management
- 100 requests/min per authenticated user for standard endpoints
- 10 concurrent upload/process initiation requests per user
- Administrative access controls: restricted by Entra group and optional corporate IP/VPN policy
- Retention in production: 90 days active data
- Archive policy: move completed execution metadata and output references to archive after 90 days
- Audit log retention: 1 year minimum

## Observability

### Platform

- Central observability platform: Azure Monitor
- Application telemetry: implementation perspectives
- Centralized records: Log Analytics workspace
- Dashboards: Azure Dashboards / Azure Monitor Workbooks
  
### Events that go to a registrar

### Security

- Login succeeded
- Login failed
- Access denied by role/policy
- Session expired
- Sensitive administrator action executed
  
### Business

- DUA execution created
- DUA execution started
- Documents upload started
- Document uploaded
- Document validation failed
- Template selected
- Template validation failed
- Processing stage changed
- Warning detected
- Execution completed
- Execution failed
- Execution retried
- Result reviewed
- Result downloaded
- Execution archivedDUA execution created
- DUA execution started
- Documents upload started
- Document uploaded
- Document validation failed
- Template selected
- Template validation failed
- Processing stage changed
- Warning detected
- Execution completed
- Execution failed
- Execution retried
- Result reviewed
- Result downloaded
- Execution archived

### Technicians

- API request received
- API request failed
- Dependency call failed
- Blob storage upload failed
- Database timeout
- Notification dispatch failed
- Background job retry triggered
- Health check failed

### Minimum metrics

- API latency p50 / p95 / p99
- Error rate by endpoint
- Upload success rate
- Average processing time per execution
- Execution failure rate
- Queue/backlog length
- CPU / memory usage
- Notification delivery failures

## Infraestructure (devops)

- Source control: Azure DevOps Repos
- CI/CD automation: Azure Pipelines
- Deployment promotion: Azure DevOps Environments
- Infrastructure as Code: Bicep
- Deployment target for dev/stage/prod: Azure App Service
- Environment strategy:
  - Dev → Azure App Service (development slot/environment)
  - Stage → Azure App Service (staging slot/environment)
  - QA → Azure App Service (qa environment)
  - Prod → Azure App Service (production environment)

## Availability

- Availability target: 99.99%
- Maximum annual downtime: 0.876 hours/year
- Equivalent downtime: 52.56 minutes/year
- 
### Recovery measures

- Stateless API instances on Azure App Service
- Azure SQL with automatic backups and point-in-time restore
- Blob Storage redundancy
- Retry with exponential backoff for transient failures
- Health checks and automatic restart on unhealthy instances
- Queue-based async processing to absorb transient outages
- Graceful degradation: if notifications fail, processing result remains queryable by polling

## Scalability

### Elements growing with traffic

- Azure API Management throughput
- Azure App Service instances
- Background processing workers
- Azure Blob Storage transactions and capacity
- Database DTUs/vCores, storage and connection load
- Notification throughput
- Log volume and telemetry ingestion
- Queue/backlog depth for async processing

### Expectable bottlenecks

- Uploading files
- Asynchronous document processing
- Database scripts
- Issuance of notifications
- Excessive telemetry if instrumentation is poor

## Backend key workflows

### Upload files to generate dua

- A. Upload files to generate DUA

  - a. The client sends a request to create a new DUA execution.
  - b. The backend validates the authenticated user and permissions.
  - c. The backend creates an execution record with status Draft or PendingUpload.
  - d. The backend receives the list of files to be uploaded.
  - e. The backend opens a streaming transfer to receive each file in raw binary format.
  - f. Each file is validated by size, extension, MIME type, and malware/security rules.
  - g. Valid files are stored in Azure Blob Storage.
  - h. The backend registers file metadata in the database, including execution ID, original name, content type, blob URI reference, checksum, upload timestamp, and uploader identity.
  - i. The backend updates the execution with the uploaded document count.
  - j. If at least one required file is missing or invalid, the backend registers validation warnings or errors.
  - k. The backend returns the updated execution state and the list of accepted/rejected files.

### Setup dua template

- B. Setup DUA template

  - a. The client requests the list of supported DUA templates.
  - b. The backend retrieves active template versions from the database or configuration source.
  - c. The backend returns only templates allowed by current business rules and user permissions.
  - d. The user selects one template for the current execution.
  - e. The backend validates that the selected template is current, active, and compatible with the execution type.
  - f. The backend associates the template with the execution record.
  - g. If the selected template is invalid or obsolete, the backend rejects the operation and logs the cause.
  - h. The backend confirms the selected template and marks the execution as ready for pre-processing validation.

- C. Start processing execution

  - a. The client sends a request to start processing.
  - b. The backend validates that the execution has valid files, a valid template, and all mandatory parameters.
  - c. The backend changes the execution status to Validating.
  - d. The backend performs pre-processing validation rules.
  - e. If validation fails, the status becomes FailedValidation and the issues are stored.
  - f. If validation succeeds, the backend changes the status to Queued.
  - g. The backend publishes a processing job to the asynchronous processing component.
  - h. The worker starts the document analysis pipeline.
  - i. The backend records stage changes for monitoring and auditability.

- D. Monitor processing

  - a. The client requests execution status or receives a notification update.
  - b. The backend returns the current execution state, current stage, percentage, warnings, and timestamps.
  - c. As the worker advances, it persists stage progress events.
  - d. If ambiguities or inconsistencies are detected, warning entries are created.
  - e. If a critical processing error occurs, the execution status changes to Failed.
  - f. If processing finishes correctly, the status changes to Completed.

- E. Retrieve result

  - a. The client requests the generated result for a completed execution.
  - b. The backend verifies RESULT_VIEW permission and execution ownership policy.
  - c. The backend retrieves result metadata, confidence indicators, traceability data, and downloadable artifact references.
  - d. The backend returns the result summary for on-screen review.
  - e. If the user downloads the result, the backend verifies RESULT_DOWNLOAD policy.
  - f. The download action is registered in the audit trail.

## Architecture diagrams in layers

### Context diagram

- Actors:

  - Customs Agent
  - Support User
  - Customer Service User
  - Admin
    
- External systems:
  - Microsoft Entra ID
  - Azure Notification Hubs
  - Azure Blob Storage
  - Azure SQL Database
    
- Central System:
  - DUA Streamliner

###  Container diagram

- Containers:
  - eact Frontend SPA
  - Azure API Management
  - ASP.NET Core Backend API
  - Background Processing Module / Worker
  - Azure SQL Database
  - Azure Blob Storage
  - Azure Notification Hubs
  - Application Insights / Azure Monitor
  - Microsoft Entra ID

### Code diagram

- Layers:
  - Presentation
  - Application
  - Domain
  - Infrastructure
    
- Candidate classes:
  - ExecutionController
  - TemplateController
  - ResultController
  - ExecutionApplicationService
  - DocumentUploadService
  - TemplateService
  - ProcessingOrchestrator
  - NotificationService
  - Execution
  - Document
  - DuaTemplate
  - ExecutionResult
  - IExecutionRepository
  - IDocumentRepository
  - BlobStorageService
  - SqlExecutionRepository

## Design Considerations

### System configurations, parameters, and policies

- All system parameters must be stored as versioned source-controlled configuration.
- Environment-specific values must be externalized through Azure App Service configuration and Key Vault references.
- Authorization policies must be explicitly defined in backend code and documented with their business purpose.
- Supported file types, max sizes, retention periods, retry counts, timeout values, and allowed template versions must be centrally configured.

### Resource allocations

- App Service plan sizing must be documented for each environment.
- Database tier, storage quota, and backup policy must be documented.
- Blob Storage redundancy and lifecycle rules must be documented.
- Since no dedicated load balancer is required, horizontal recovery depends on App Service platform capabilities and deployment slot strategy.

### Algorithms and parameters

- File validation rules: extension, MIME type, checksum, max size
- Processing confidence scoring thresholds: High / Medium / Low
- Retry strategy: exponential backoff with capped retries
- Duplicate upload detection using checksum
- Template compatibility validation rules by version and execution type

### Agent prototypes

- Document Intake Agent prototype
- Template Validation Agent prototype
- Extraction Orchestrator Agent prototype
- Confidence Evaluation Agent prototype
- Notification Dispatch Agent prototype

### Interfaces, proxies, integration points

- Frontend ↔ Backend API via HTTPS/JSON REST
- Backend ↔ Entra ID via App Service Authentication context
- Backend ↔ Azure Blob Storage via SDK and Managed Identity
- Backend ↔ Azure SQL via secure connection string / managed auth if enabled
- Backend ↔ Notification Hubs via Azure SDK
- Backend ↔ Azure Monitor / Application Insights telemetry pipeline

## Source Code

## Source Code

The backend source code skeleton was generated as a structural baseline for the proposed modular monolith architecture with Cursor AI.  
It includes folder organization, project boundaries, controllers, application services, domain entities, repository contracts, infrastructure adapters, security placeholders, and async processing abstractions, without implementing functional business logic.

### Backend structure
- [Backend root](./DUA_Src_Code/)
- [Backend README](./DUA_Src_Code/README.md)
- [Solution](./DUA_Src_Code/DUAStreamliner.sln)

### Main layers
- [API layer](./DUA_Src_Code/src/Api/)
- [Application layer](./DUA_Src_Code/src/Application/)
- [Domain layer](./DUA_Src_Code/src/Domain/)
- [Infrastructure layer](./DUA_Src_Code/src/Infrastructure/)
- [Shared layer](./DUA_Src_Code/src/Shared/)

### Key classes
- [ExecutionsController](./DUA_Src_Code/src/Api/Controllers/ExecutionsController.cs)
- [ExecutionAppService](./DUA_Src_Code/src/Application/Executions/ExecutionAppService.cs)
- [Execution entity](./DUA_Src_Code/src/Domain/Executions/Execution.cs)
- [IExecutionRepository](./DUA_Src_Code/src/Application/Executions/IExecutionRepository.cs)

#Data design
