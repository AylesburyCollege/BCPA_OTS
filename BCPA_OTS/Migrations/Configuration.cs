namespace BCPA_OTS.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using BCPA_OTS.DAL;
    using BCPA_OTS.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<BCPA_OTS.DAL.OTS_Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "BCPA_OTS.DAL.OTS_Context";
        }

        protected override void Seed(BCPA_OTS.DAL.OTS_Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            SeedPeople(context);

            SeedPaymentCard(context);
        }

        private void SeedPaymentCard(OTS_Context context)
        {
            var PaymentCardList = new List<PaymentCard>
            {
                new PaymentCard
                {
                    PaymentCardID = 1,
                    HolderName = "William Foster",
                    CardNumber = "1234 1234 1234 1234",
                    CardType = CardTypes.VISA_DEBIT,
                    ExpiryMonth = 8,
                    ExpiryYear = 2021,
                    SecurityNumber = "123"
                },

                new PaymentCard
                {
                    PaymentCardID = 2,
                    HolderName = "Connor Patey",
                    CardNumber = "8655 5024 1096 2694",
                    CardType = CardTypes.VISA_DEBIT,
                    ExpiryMonth = 4,
                    ExpiryYear = 2023,
                    SecurityNumber = "414"
                },

                new PaymentCard
                {
                    PaymentCardID = 3,
                    HolderName = "Daniel Schafer-Smith",
                    CardNumber = "5763 8998 4321 0945",
                    CardType = CardTypes.PAYPAL,
                    ExpiryMonth = 2,
                    ExpiryYear = 2020,
                    SecurityNumber = "641"
                },

                new PaymentCard
                {
                    PaymentCardID = 4,
                    HolderName = "Zeeshan Akhlaq",
                    CardNumber = "5011 6100 1897 1842",
                    CardType = CardTypes.MASTERCARD,
                    ExpiryMonth = 8,
                    ExpiryYear = 2020,
                    SecurityNumber = "871"
                },

                new PaymentCard
                {
                    PaymentCardID = 5,
                    HolderName = "Tomas Green",
                    CardNumber = "1963 4532 1829 4110",
                    CardType = CardTypes.VISA_CREDIT,
                    ExpiryMonth = 1,
                    ExpiryYear = 2022,
                    SecurityNumber = "661"
                },

                new PaymentCard
                {
                    PaymentCardID = 6,
                    HolderName = "Ben Miller",
                    CardNumber = "6736 8723 9846 9021",
                    CardType = CardTypes.PAYPAL,
                    ExpiryMonth = 5,
                    ExpiryYear = 2020,
                    SecurityNumber = "432"
                },

                new PaymentCard
                {
                    PaymentCardID = 7,
                    HolderName = "Lilly Erikson",
                    CardNumber = "5001 7152 9234 0166",
                    CardType = CardTypes.MASTERCARD,
                    ExpiryMonth = 11,
                    ExpiryYear = 2021,
                    SecurityNumber = "313"
                },

                new PaymentCard
                {
                    PaymentCardID = 8,
                    HolderName = "Joshua Knight",
                    CardNumber = "9851 9362 3367 8585",
                    CardType = CardTypes.PAYPAL,
                    ExpiryMonth = 9,
                    ExpiryYear = 2020,
                    SecurityNumber = "983"
                },

                new PaymentCard
                {
                    PaymentCardID = 9,
                    HolderName = "Emily White",
                    CardNumber = "2168 6188 6253 1323",
                    CardType = CardTypes.VISA_CREDIT,
                    ExpiryMonth = 4,
                    ExpiryYear = 2022,
                    SecurityNumber = "701"
                },

                new PaymentCard
                {
                    PaymentCardID = 10,
                    HolderName = "Eliot Myers",
                    CardNumber = "7511 8012 1022 4834",
                    CardType = CardTypes.MASTERCARD,
                    ExpiryMonth = 1,
                    ExpiryYear = 2022,
                    SecurityNumber = "121"
                }

            };

            PaymentCardList.ForEach(p => context.PaymentCards.AddOrUpdate(i => i.PaymentCardID, p));
            context.SaveChanges();
        }

        private void SeedPeople(OTS_Context context)
        {
            var PeopleList = new List<Person>
            {
                new Person
                {
                    PersonID = 1,
                    FirstName = "William",
                    LastName = "Foster",
                    HomePhoneNumber = "01296 123123",
                    MobilePhoneNumber = "07123 456789",
                    DateOfBirth = new System.DateTime(1994, 8, 28),
                    Email = "william.foster@nomad.com",
                    PaymentCardID = 1
                },
                new Person
                {
                    PersonID = 2,
                    FirstName = "Connor",
                    LastName = "Patey",
                    HomePhoneNumber = "01296 789456",
                    MobilePhoneNumber = "07976 123456",
                    DateOfBirth = new System.DateTime(1999, 10, 10),
                    Email = "connor.patey@nomad.com",
                    PaymentCardID = 2

                },
                new Person
                {
                    PersonID = 3,
                    FirstName = "Daniel",
                    LastName = "Schafer-Smith",
                    HomePhoneNumber = "01296 543219",
                    MobilePhoneNumber = "07890 432123",
                    DateOfBirth = new System.DateTime(1999, 10, 10),
                    Email = "daniel.schafer_smith@nomad.com",
                    PaymentCardID = 3

                },
                new Person
                {
                    PersonID = 4,
                    FirstName = "Zeeshan",
                    LastName = "Akhlaq",
                    HomePhoneNumber = "01494 212868",
                    MobilePhoneNumber = "07576 123789",
                    DateOfBirth = new System.DateTime(1999, 10, 10),
                    Email = "zeeshan.akhlaq@nomad.com",
                    PaymentCardID = 4

                },
                new Person
                {
                    PersonID = 5,
                    FirstName = "Tomas",
                    LastName = "Green",
                    HomePhoneNumber = "01485 361516",
                    MobilePhoneNumber = "07658 154321",
                    DateOfBirth = new System.DateTime(1994, 12, 2),
                    Email = "TomasGreen94@gmail.com",
                    PaymentCardID = 5

                },
                new Person
                {
                    PersonID = 6,
                    FirstName = "Ben",
                    LastName = "Miller",
                    HomePhoneNumber = "01964 201603",
                    MobilePhoneNumber = "07633 645591",
                    DateOfBirth = new System.DateTime(1992, 3, 12),
                    Email = "Miller92@gmail.com",
                    PaymentCardID = 6

                },
                new Person
                {
                    PersonID = 7,
                    FirstName = "Lilly",
                    LastName = "Erickson",
                    HomePhoneNumber = "01223 191608",
                    MobilePhoneNumber = "07894 231745",
                    DateOfBirth = new System.DateTime(1985, 7, 30),
                    Email = "Lilly1985@gmail.com",
                    PaymentCardID = 7

                },
                new Person
                {
                    PersonID = 8,
                    FirstName = "Joshua",
                    LastName = "Knight",
                    HomePhoneNumber = "01356 624619",
                    MobilePhoneNumber = "07123 548672",
                    DateOfBirth = new System.DateTime(1990, 11, 23),
                    Email = "JoshKnight90@gmail.com",
                    PaymentCardID = 8

                },
                new Person
                {
                    PersonID = 9,
                    FirstName = "Emily",
                    LastName = "White",
                    HomePhoneNumber = "01494 432674",
                    MobilePhoneNumber = "07368 213875",
                    DateOfBirth = new System.DateTime(1981, 4, 5),
                    Email = "EWhite@gmail.com",
                    PaymentCardID = 9

                },
                new Person
                {
                    PersonID = 10,
                    FirstName = "Eliot",
                    LastName = "Meyers",
                    HomePhoneNumber = "01296 431652",
                    MobilePhoneNumber = "07896 787712",
                    DateOfBirth = new System.DateTime(1956, 9, 21),
                    Email = "EliotMey@gmail.com",
                    PaymentCardID = 10

                }

            };

            PeopleList.ForEach(p => context.People.AddOrUpdate(i => i.LastName, p));
            context.SaveChanges();
        }
    }
    
}
