using System;


namespace Lesson_1_HomeWork_1
{
    class DefaultIdGenerator : IIdGenerator
    {
        public long CalculateId()
        {
            long id = DateTime.Now.Ticks;
            return id;
        }
    }
}