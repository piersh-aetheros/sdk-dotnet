﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Threading.Tasks;
using GridNet.IoT.Types;
using GridNet.OneM2M.Types;
using Microsoft.Extensions.Options;

namespace GridNet.IoT.Web.React.server.Services
{
	public class MeterService
	{
		readonly ModelContext _modelContext;

		public Meter GetMeter(string meterId) => _modelContext.Meters[meterId];
		public IObservable<Meter> Meters { get; }

		public MeterService(ModelContext modelContext)
		{
			_modelContext = modelContext;

			Meters = _modelContext.Meters.Select(m => m.Value).ToObservable();
		}

		public ModelContext GetContext() => _modelContext;

		public async Task<IEnumerable<Data.Summation>> GetOldSummations(string meterId, int dataSummationWindow)
		{
			var windowTimeSpan = new TimeSpan(0, 0, dataSummationWindow, 0);
			return await _modelContext.GetOldSummations(meterId, windowTimeSpan);
		}

		public async Task<IEnumerable<Events.MeterEvent>> GetOldEvents(string meterId) => await _modelContext.GetOldEvents(meterId);

		public async Task<T> GetLatestContentInstance<T>(string containerKey)
			where T : class => await _modelContext.App.Application.GetLatestContentInstance<T>(containerKey);

		public async Task AddInfo(Info record) => await _modelContext.App.Application.AddContentInstance(_modelContext.App.InfoContainer, record);

		public async Task AddState(State record) => await _modelContext.App.Application.AddContentInstance(_modelContext.App.StateContainer, record);

		public async Task AddCommand(Command record) => await _modelContext.App.Application.AddContentInstance(_modelContext.App.CommandContainer, record);

		public async Task AddMeterReadPolicy(Config.MeterReadPolicy record) => await _modelContext.App.Application.AddContentInstance(_modelContext.App.ConfigContainer, record);
	}
}
