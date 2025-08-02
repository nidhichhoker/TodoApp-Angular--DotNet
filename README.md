# TODO List Application

A full-stack TODO list application built with Angular 18 frontend and .NET 9 Web API backend.

## 🚀 Features

- ✅ View all TODO items
- ✅ Add new TODO items with title and description
- ✅ Mark items as completed/incomplete
- ✅ Delete TODO items
- ✅ View/Hide task descriptions with toggle button
- ✅ Responsive design for mobile and desktop
- ✅ Real-time updates between frontend and backend
- ✅ Form validation with error messages
- ✅ Comprehensive error handling
- ✅ Sample data preloaded for immediate testing

## 🏗️ Architecture

- **Frontend**: Angular 18 with TypeScript, standalone components
- **Backend**: .NET 9 Web API with clean architecture
- **Data Storage**: In-memory storage (as requested)
- **Testing**: xUnit for backend, Jasmine/Karma for frontend
- **Communication**: RESTful API with HTTP client
- **CORS**: Configured for cross-origin requests

## 🛠️ Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download)
- [Node.js 18+](https://nodejs.org/)
- [Angular CLI](https://angular.io/cli)

## ⚡ Quick Start

### Backend Setup

1. Navigate to the backend directory:

cd backend/TodoApi
dotnet restore
dotnet build
dotnet run

The API will be available at: 
HTTP: http://localhost:5149
API Base URL: http://localhost:5149/api/todo

Frontend Setup

1. Navigate to the frontend directory:
   bashcd frontend

Install npm packages:

bashnpm install

Start the development server:

bashng serve
The application will be available at http://localhost:4200
🧪 Running Tests
Backend Tests
bashcd backend/TodoApi.Tests
dotnet test
Frontend Tests
bashcd frontend
ng test
📚 API Documentation
Base URL- http://localhost:5149/api/todo

Data Models
TodoItem
json{
  "id": 1,
  "title": "Sample Task",
  "description": "Task description",
  "isCompleted": false,
  "createdAt": "2025-01-01T00:00:00Z",
  "completedAt": null
}
CreateTodoRequest
json{
  "title": "New Task",
  "description": "Optional description"
}
🎯 Application Features
Frontend Features

Add Task Form: Title (required, max 200 chars) and description (optional, max 1000 chars)
Task List: Display all tasks with completion status
View Toggle: Show/hide task descriptions with "View" button
Mark Complete: Toggle completion status with visual feedback
Delete Tasks: Remove tasks with confirmation
Validation: Real-time form validation with error messages
Responsive Design: Works on mobile and desktop
Error Handling: User-friendly error messages for API failures

Backend Features

Clean Architecture: Separation of controllers, services, and models
Dependency Injection: Loose coupling and testability
Data Validation: Model validation with attributes
Error Handling: Comprehensive exception handling and logging
CORS Support: Cross-origin requests enabled for frontend
Thread Safety: Concurrent operations with ConcurrentDictionary
Sample Data: Pre-loaded with 3 sample todos for testing

📁 Project Structure
TodoApp/
├── backend/
│   ├── TodoApi/
│   │   ├── Controllers/         # API controllers (TodoController)
│   │   ├── Models/             # Data models and DTOs
│   │   ├── Services/           # Business logic (TodoService)
│   │   └── Program.cs          # App configuration and startup
│   └── TodoApi.Tests/          # Unit tests
└── frontend/
    ├── src/app/
    │   ├── components/         # Angular components (TodoList)
    │   ├── models/            # TypeScript interfaces
    │   ├── services/          # API services (TodoService)
    │   └── app.ts             # Main app component
    └── package.json
🔧 Development Notes
Important Configuration

Backend Port: 5149 (configured in CORS)
Frontend Port: 4200 (Angular default)
Data Persistence: In-memory only (resets on server restart)
CORS Policy: Allows requests from http://localhost:4200

Sample Data
The application starts with 3 pre-loaded tasks:

"Grocery" (incomplete)
"Laundry" (completed)
"Doctor's Appoinment" (incomplete)

Best Practices Implemented

TypeScript: Strong typing throughout the application
Async/Await: Non-blocking operations
Error Boundaries: Proper error handling at all layers
Validation: Client and server-side validation
Testing: Unit tests for critical functionality
Code Organization: Clean separation of concerns

🚀 Production Considerations
While this is a demo application with in-memory storage, it's built with production-ready patterns:

Database Integration: Easy to swap in-memory storage for Entity Framework
Authentication: Architecture supports adding JWT authentication
Deployment: Ready for containerization with Docker
Scalability: Async patterns support high-concurrency scenarios
Monitoring: Logging infrastructure in place

❓ Troubleshooting
Common Issues
"Connection refused" errors:

Ensure backend is running on port 5149
Check CORS configuration in Program.cs

"Module not found" errors:

Run npm install in frontend directory
Ensure Angular CLI is installed globally

Build errors:

Verify .NET 9 SDK is installed
Run dotnet restore in backend directory

Getting Help
If you encounter issues:

Check that both servers are running
Verify ports 4200 and 5149 are available
Ensure all prerequisites are installed
Check browser console for detailed error messages

👨‍💻 Built With

Backend: .NET 9, ASP.NET Core Web API, xUnit, Moq
Frontend: Angular 18, TypeScript, RxJS, Angular Forms
Tools: Visual Studio, Angular CLI, Git, GitHub Desktop
Testing: xUnit (.NET), Jasmine/Karma (Angular)


Note: This application demonstrates modern full-stack development practices using the latest versions of Angular and .NET, following industry best practices for maintainable, testable, and scalable code.
