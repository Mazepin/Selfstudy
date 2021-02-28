using System;
using System.Collections.Generic;
using System.Text;

namespace TestPr30_Const_vs_Readonly
{
    class Car
    {
        private const string ENGINE_IS_STARTED_MESSAGE = "Engine sterted!"; // объявляем константу, ее нельзя изменить
        private const string ATTEMP_TO_START_ENGINE_MESSAGE = "Starting the engine!";
        private const string ENGINE_HAS_ALREADY_STARTED_MESSAGE = "Engine has already started!";
        private const string ATTEMP_TO_DRIVE_MESSAGE = "Press the treadle!";
        private const string DRIVE_MESSAGE = "You can go!";
        private const string DRIVE_ERROR_MESSAGE = "Start the engine first!";

        private readonly MyLogger _myLogger; // объявляем константу, но пока не знаем ее значения

        private bool isEngineStarted;

        public Car(MyLogger myLogger)
        {
            _myLogger = myLogger;
        }

        public void StartEngine()
        {
            _myLogger.Info(ATTEMP_TO_START_ENGINE_MESSAGE);

            if (isEngineStarted)
            {
                _myLogger.Warning(ENGINE_HAS_ALREADY_STARTED_MESSAGE);
            }
            else
            {
                isEngineStarted = true;
                _myLogger.Info(ENGINE_IS_STARTED_MESSAGE);
            }
        }

        public void Drive()
        {
            _myLogger.Info(ATTEMP_TO_DRIVE_MESSAGE);

            if (isEngineStarted)
            {
                _myLogger.Info(DRIVE_MESSAGE);
            }
            else
                _myLogger.Error(DRIVE_ERROR_MESSAGE);
        }
    }
}
