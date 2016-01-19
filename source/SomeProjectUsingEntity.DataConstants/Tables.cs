namespace SomeProjectUsingEntity.DataConstants
{
    public class Tables
    {
        public class SomeEntity
        {
            public const string NAME = "SomeEntities";
            public class Columns
            {
                public const string ID = "Id";
                public const string NAME = "Name";
                public const string NOTES = "Notes";
            }
        }

        public class SomeChildEntity
        {
            public const string NAME = "SomeChildEntities";
            public class Columns
            {
                public const string ID = "Id";
                public const string SOME_ENTITY_ID = "SomeEntityId";
                public const string NAME = "Name";
            }
        }
    }
}
