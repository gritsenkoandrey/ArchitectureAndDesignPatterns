﻿namespace Builder_2
{
    public class Director
    {
        private Builder _builder;

        public Director(Builder builder)
        {
            _builder = builder;
        }

        public void Construct()
        {
            _builder.BuildPartA();
            _builder.BuildPartB();
            _builder.BuildPartC();
        }
    }
}