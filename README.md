# Restaurant

This repository contains the source code for the Restaurant project, a web application aimed at helping users discover and explore different restaurants.

## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [Technologies](#technologies)
- [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## Introduction

The Restaurant project is an ASP .Net Core MVC web application designed to provide a comprehensive online store solution with core features and robust administrative capabilities. The application allows for seamless creation, reading, updating, and deletion operations, making it an ideal choice for businesses seeking a powerful and scalable online platform. With its intuitive interface and robust functionality, Restaurant is an excellent choice for businesses seeking to establish a professional and reliable online presence.

## Features

- Browse and search for products using Search bar.
- View detailed information about each restaurant, including contact details, operating hours, and menu options.
- Add item to the shopping cart & place order.
- User-friendly interface with an intuitive design for a seamless browsing experience.

## Technologies

The Restaurant project utilizes the following technologies:

- Frontend: HTML5, CSS3, JavaScript
- Backend: ASP.NET Core MVC, C#, Entity Framework Core
- Database: Microsoft SQL Server

## Installation

To run the Restaurant project locally, please ensure you have the following prerequisites installed:

- .NET Core SDK
- SQL Server

Follow these steps to set up the project:

1. Clone the repository: `git clone https://github.com/KareemEL-Dessouky/Restaurant.git`
2. Navigate to the project directory: `cd Restaurant`
3. Install frontend dependencies: `npm install`
4. Install backend dependencies: `dotnet restore`
5. Configure the database connection in the appsettings.json file.
6. Apply database migrations: `dotnet ef database update`
7. Build and run the project: `dotnet run`
