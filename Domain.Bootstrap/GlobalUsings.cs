﻿global using Domain.Contracts.Tickets;
global using Domain.Contracts.Tickets.Queries.GetById;
global using Domain.Contracts.Trains.Commands;
global using Domain.Contracts.Trains.Commands.CreateTrain;
global using Domain.Contracts.Trains.Queries;
global using Domain.Contracts.Trains.Queries.GetById;
global using Domain.Contracts.Users.Commands;
global using Domain.Contracts.Users.Commands.CreateUser;
global using Domain.Contracts.Users.Queries;
global using Domain.Contracts.Users.Queries.GetById;
global using Domain.Implementations.Tickets.Behaviour.Validators;
global using Domain.Implementations.Tickets.Queries;
global using Domain.Implementations.Tickets.Queries.GetById;
global using Domain.Implementations.Trains.Behaviour.Validators;
global using Domain.Implementations.Trains.Commands;
global using Domain.Implementations.Trains.Commands.CreateTrain;
global using Domain.Implementations.Trains.Queries;
global using Domain.Implementations.Trains.Queries.GetById;
global using Domain.Implementations.Users.Behaviour.Validators;
global using Domain.Implementations.Users.Commands;
global using Domain.Implementations.Users.Commands.CreateUser;
global using Domain.Implementations.Users.Queries;
global using Domain.Implementations.Users.Queries.GetById;
global using FluentValidation;
global using Libraries.PasswordManager.Extensions;
global using Microsoft.Extensions.DependencyInjection;
