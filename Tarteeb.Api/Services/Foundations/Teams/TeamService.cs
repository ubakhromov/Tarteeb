﻿//=================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free to use to bring order in your workplace
//=================================

namespace Tarteeb.Api.Services.Foundations.Teams
{
    public partial class TeamService : ITeamService
    {
        private readonly IStorageBroker storageBroker;
        private readonly IDateTimeBroker dateTimeBroker;
        private readonly ILoggingBroker loggingBroker;

        public TeamService(
            IStorageBroker storageBroker,
            IDateTimeBroker dateTimeBroker,
            ILoggingBroker loggingBroker)

        {
            this.storageBroker = storageBroker;
            this.dateTimeBroker = dateTimeBroker;
            this.loggingBroker = loggingBroker;
        }

        public ValueTask<Team> AddTeamAsync(Team team) =>
        TryCatch(async () =>
        {
            ValidateTeam(team);

            return await this.storageBroker.InsertTeamAsync(team);
        });
        public IQueryable<Team> RetrieveAllTeams() =>
            TryCatch(() => this.storageBroker.SelectAllTeams());
    }
}