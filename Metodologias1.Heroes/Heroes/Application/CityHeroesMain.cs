using System;
using System.Collections.Generic;
using Application.Heroes;
using Application.Places;
using Domain.Place;
using Domain.RandomValue;
using Heroes.Domain.Compliants;
using Heroes.Domain.Doctor;
using Heroes.Domain.FactoryHeroes;
using Heroes.Domain.Fireman;
using Heroes.Domain.Fireman.FiremanProxy;
using Heroes.Domain.HeroesProxy;
using Heroes.Domain.Place;
using Heroes.Domain.Police;
using Heroes.Domain.Quarter;
using Heroes.Domain.Quarter.Tool;
using Heroes.Domain.Quarter.Vehicle;
using HeroesDeCiudad;

namespace Heroes
{
    class CityHeroesMain
    {
        static void Main(string[] args)
        {
            Proxy();
            Console.ReadKey();
        }

        static void Proxy()
        {
            var A = new House(100, 25, 4);
            var B = new House(102, 16, 1);
            var C = new House(104, 34, 5);
            var D = new House(106, 20, 3);
            var E = new House(108, 9, 2);
            var F = new House(109, 25, 4);
            var G = new Square("G", 16, 2, 5);
            var H = new Square("H", 16, 2, 5);
            var I = new Square("I", 16, 2, 5);
            var J = new Square("J", 36, 5, 4);

            var street = new Street(110, 64, 25);
            A.Street = street;
            B.Street = street;
            C.Street = street;
            D.Street = street;
            E.Street = street;
            F.Street = street;
            G.Street = street;
            H.Street = street;
            I.Street = street;
            J.Street = street;

            G.Builder = new mixedBuilder();
            H.Builder = new FavorableBuilder();
            I.Builder = new UnfavorableBuilder();

            // WHATSAPP
            WhatsAppMessage whatsAppList = null;
            whatsAppList = new WhatsAppMessage(new FireReport(G), whatsAppList);
            whatsAppList = new WhatsAppMessage(new FireReport(H), whatsAppList);
            whatsAppList = new WhatsAppMessage(new FireReport(I), whatsAppList);

            // HEART ATTACK - 2
            var passerbyReport = new HearthAttackReport();
            passerbyReport.Pedestrian = new Passerby();
            whatsAppList = new WhatsAppMessage(passerbyReport, whatsAppList);

            var foreignPasserbyReport = new HearthAttackReport();
            var passerbyAddapter = new ForeignPasserbyAdapter(new ForeignPasserby(pc: 0.20, pb: 0.30, phr: 0.50));
            foreignPasserbyReport.Pedestrian = passerbyAddapter;
            whatsAppList = new WhatsAppMessage(foreignPasserbyReport, whatsAppList);

            // ROBBERY - 3
            var robbertyReport1 = new RobberyReport();
            robbertyReport1.Place = A;
            whatsAppList = new WhatsAppMessage(robbertyReport1, whatsAppList);

            var robbertyReport2 = new RobberyReport();
            robbertyReport2.Place = B;
            whatsAppList = new WhatsAppMessage(robbertyReport2, whatsAppList);

            var robbertyReport3 = new RobberyReport();
            robbertyReport3.Place = J;
            whatsAppList = new WhatsAppMessage(robbertyReport3, whatsAppList);

            // BURNT LAMPS - 5 
            var burntReport1 = new BurntLampReport();
            burntReport1.Place = street;
            whatsAppList = new WhatsAppMessage(burntReport1, whatsAppList);

            var burntReport2 = new BurntLampReport();
            burntReport2.Place = street;
            whatsAppList = new WhatsAppMessage(burntReport2, whatsAppList);

            var burntReport3 = new BurntLampReport();
            burntReport3.Place = street;
            whatsAppList = new WhatsAppMessage(burntReport3, whatsAppList);

            var burntReport4 = new BurntLampReport();
            burntReport4.Place = street;
            whatsAppList = new WhatsAppMessage(burntReport4, whatsAppList);

            var burntReport5 = new BurntLampReport();
            burntReport5.Place = street;
            whatsAppList = new WhatsAppMessage(burntReport5, whatsAppList);

            var complaintsByWhatsapp = new ComplaintByWhatsapp(whatsAppList);

            // TEST
            CompliantHandler handler = new CopProxy().CreateHeroe();
            handler = new FiremanProxy().CreateHeroe(handler);
            handler = new ElectricianProxy().CreateHeroe(handler);
            handler = new MedicProxy().CreateHeroe(handler);

            var operator911 = new Operator911(handler);
            operator911.AttendReport(complaintsByWhatsapp);
        }

        static void Singleton()
        {
            var copFactory = new CopFactory();
            var quarter = CreateHeroe(copFactory);

            for (int i = 0; i < 4; i++)
            {
                quarter.AddResponsable(copFactory.CreateHeroe());
                quarter.AddTool(copFactory.CreateTool());
                quarter.AddVehicle(copFactory.CreateVehicle());
            }

            IResponsable b1 = quarter.GetPersonal();
            IResponsable b2 = quarter.GetPersonal();
            IResponsable b3 = quarter.GetPersonal();
            IResponsable b4 = quarter.GetPersonal();
        }

        static void AbstractFactory()
        {
            var copFactory = new CopFactory();
            var quarter = CreateHeroe(copFactory);
            var personal = (Cop)quarter.GetPersonal();
            personal.PatrolStreet(new House(100, 25, 4));
            quarter.AddResponsable(personal);
            quarter.AddTool(personal.Tool);
            quarter.AddVehicle(personal.Vehicle);

            var fireFactory = new FireFighterFactory();
            quarter = CreateHeroe(fireFactory);
            var personal2 = (Firefighter)quarter.GetPersonal();
            personal2.PutOutFire(new House(100, 25, 4), new Street(25, 4, 10));
            quarter.AddResponsable(personal2);
            quarter.AddTool(personal2.Tool);
            quarter.AddVehicle(personal2.Vehicle);

            var electriciaFactory = new ElectricianFactory();
            quarter = CreateHeroe(electriciaFactory);
            var personal3 = (Electrician)quarter.GetPersonal();
            personal3.changeBurntLamps(new Street(25, 4, 10));
            quarter.AddResponsable(personal3);
            quarter.AddTool(personal3.Tool);
            quarter.AddVehicle(personal3.Vehicle);
        }

        static void ChainOfResponsability()
        {
            var A = new House(100, 25, 4);
            var B = new House(102, 16, 1);
            var C = new House(104, 34, 5);
            var D = new House(106, 20, 3);
            var E = new House(108, 9, 2);
            var F = new House(109, 25, 4);
            var G = new Square("G", 16, 2, 5);
            var H = new Square("H", 16, 2, 5);
            var I = new Square("I", 16, 2, 5);
            var J = new Square("J", 36, 5, 4);

            var street = new Street(110, 64, 25);
            A.Street = street;
            B.Street = street;
            C.Street = street;
            D.Street = street;
            E.Street = street;
            F.Street = street;
            G.Street = street;
            H.Street = street;
            I.Street = street;
            J.Street = street;

            G.Builder = new mixedBuilder();
            H.Builder = new FavorableBuilder();
            I.Builder = new UnfavorableBuilder();

            // WHATSAPP
            WhatsAppMessage whatsAppList = null;
            whatsAppList = new WhatsAppMessage(new FireReport(G), whatsAppList);
            whatsAppList = new WhatsAppMessage(new FireReport(H), whatsAppList);
            whatsAppList = new WhatsAppMessage(new FireReport(I), whatsAppList);

            // HEART ATTACK - 2
            var passerbyReport = new HearthAttackReport();
            passerbyReport.Pedestrian = new Passerby();
            whatsAppList = new WhatsAppMessage(passerbyReport, whatsAppList);

            var foreignPasserbyReport = new HearthAttackReport();
            var passerbyAddapter = new ForeignPasserbyAdapter(new ForeignPasserby(pc: 0.20, pb: 0.30, phr: 0.50));
            foreignPasserbyReport.Pedestrian = passerbyAddapter;
            whatsAppList = new WhatsAppMessage(foreignPasserbyReport, whatsAppList);

            // ROBBERY - 3
            var robbertyReport1 = new RobberyReport();
            robbertyReport1.Place = A;
            whatsAppList = new WhatsAppMessage(robbertyReport1, whatsAppList);

            var robbertyReport2 = new RobberyReport();
            robbertyReport2.Place = B;
            whatsAppList = new WhatsAppMessage(robbertyReport2, whatsAppList);

            var robbertyReport3 = new RobberyReport();
            robbertyReport3.Place = J;
            whatsAppList = new WhatsAppMessage(robbertyReport3, whatsAppList);

            // BURNT LAMPS - 5 
            var burntReport1 = new BurntLampReport();
            burntReport1.Place = street;
            whatsAppList = new WhatsAppMessage(burntReport1, whatsAppList);

            var burntReport2 = new BurntLampReport();
            burntReport2.Place = street;
            whatsAppList = new WhatsAppMessage(burntReport2, whatsAppList);

            var burntReport3 = new BurntLampReport();
            burntReport3.Place = street;
            whatsAppList = new WhatsAppMessage(burntReport3, whatsAppList);

            var burntReport4 = new BurntLampReport();
            burntReport4.Place = street;
            whatsAppList = new WhatsAppMessage(burntReport4, whatsAppList);

            var burntReport5 = new BurntLampReport();
            burntReport5.Place = street;
            whatsAppList = new WhatsAppMessage(burntReport5, whatsAppList);

            var complaintsByWhatsapp = new ComplaintByWhatsapp(whatsAppList);

            // TEST
            CompliantHandler handler = new Medic(new RCPTypeA());
            handler = new Firefighter(handler);
            handler = new Electrician(handler);
            handler = new Cop(new RequestBackup(), handler);

            var operator911 = new Operator911(handler);
            operator911.AttendReport(complaintsByWhatsapp);
        }

        static void Iterator()
        {
            var A = new House(100, 25, 4);
            var B = new House(102, 16, 1);
            var C = new House(104, 34, 5);
            var D = new House(106, 20, 3);
            var E = new House(108, 9, 2);
            var F = new House(109, 25, 4);
            var G = new Square("G", 16, 2, 5);
            var H = new Square("H", 16, 2, 5);
            var I = new Square("I", 16, 2, 5);
            var J = new Square("J", 36, 5, 4);

            var street = new Street(110, 64, 25);
            A.Street = street;
            B.Street = street;
            C.Street = street;
            D.Street = street;
            E.Street = street;
            F.Street = street;
            G.Street = street;
            H.Street = street;
            I.Street = street;
            J.Street = street;

            G.Builder = new mixedBuilder();
            H.Builder = new FavorableBuilder();
            I.Builder = new UnfavorableBuilder();

            // BOARD
            var complaintsByBoard = new ComplaintByBoard();
            A.AddObserver(complaintsByBoard);
            B.AddObserver(complaintsByBoard);
            C.AddObserver(complaintsByBoard);
            D.AddObserver(complaintsByBoard);
            E.AddObserver(complaintsByBoard);
            F.AddObserver(complaintsByBoard);

            // WHATSAPP
            WhatsAppMessage whatsAppList = null;
            whatsAppList = new WhatsAppMessage(new FireReport(G), whatsAppList);
            whatsAppList = new WhatsAppMessage(new FireReport(H), whatsAppList);
            whatsAppList = new WhatsAppMessage(new FireReport(I), whatsAppList);
            var complaintsByWhatsapp = new ComplaintByWhatsapp(whatsAppList);

            // DESK
            var complaintsByDesk = new ComplaintByDesk(J);

            B.Spark();
            F.Spark();

            // TEST
            var fireman = new Firefighter();
            fireman.Vehicle = new FireTruck();
            fireman.Tool = new WaterHose();
            var secretary = new FirefighterSecretary(fireman);

            secretary.AttendCompliant(complaintsByBoard);
            secretary.AttendCompliant(complaintsByDesk);
            Console.Clear();
            secretary.AttendCompliant(complaintsByWhatsapp);
        }

        static void Observer()
        {
            var fireman = new Firefighter();

            var house1 = new House(100, 25, 4);
            var house2 = new House(102, 16, 1);
            var house3 = new House(104, 34, 5);
            var house4 = new House(106, 20, 3);
            var house5 = new House(108, 9, 2);
            var square = new Square("San Martin", 36, 5, 4);
            var street = new Street(110, 64, 25);

            house1.Street = street;
            house1.AddObserver(fireman);
            house2.Street = street;
            house2.AddObserver(fireman);
            house3.Street = street;
            house3.AddObserver(fireman);
            house4.Street = street;
            house4.AddObserver(fireman);
            house5.Street = street;
            house5.AddObserver(fireman);
            square.Street = street;
            square.AddObserver(fireman);
            house5.Spark();
            square.Spark();
        }

        static void Composite()
        {
            var elictrician = new Electrician();

            #region mocks
            // StreetCorners
            var corner1 = new StreetCorner(1);
            var corner2 = new StreetCorner(4);
            var corner3 = new StreetCorner(2);
            var corner4 = new StreetCorner(3);
            var corner5 = new StreetCorner(2);
            var corner6 = new StreetCorner(1);
            var corner7 = new StreetCorner(3);
            var corner8 = new StreetCorner(3);
            var corner9 = new StreetCorner(5);
            var corner10 = new StreetCorner(1);

            // Streets
            var street1 = new Street(110, 10, 25);
            var street2 = new Street(100, 12, 20);
            var street3 = new Street(80, 5, 10);
            var street4 = new Street(90, 8, 30);
            var street5 = new Street(70, 2, 15);
            var street6 = new Street(115, 3, 35);
            var street7 = new Street(105, 2, 30);
            var street8 = new Street(105, 4, 20);
            var street9 = new Street(85, 4, 15);

            // Squares
            var square1 = new Square("San Martin", 36, 5, 4);
            var square2 = new Square("Italia", 36, 5, 4);
            var square3 = new Square("Lezama", 36, 5, 4);
            var square4 = new Square("Plaza de Mayo", 60, 45, 20);


            // NeighborhoodA: 9 blocks, 2 square

            // Blocks
            var block1 = new CompositePlace();
            block1.AddPlace(street1);
            block1.AddPlace(street5);
            block1.AddPlace(corner1);

            var block2 = new CompositePlace();
            block2.AddPlace(street1);
            block2.AddPlace(street5);
            block2.AddPlace(street6);
            block2.AddPlace(corner1);
            block2.AddPlace(corner2);

            var block3 = new CompositePlace();
            block3.AddPlace(street1);
            block3.AddPlace(street6);
            block3.AddPlace(street7);
            block3.AddPlace(corner2);
            block3.AddPlace(corner3);
            block3.AddPlace(square1);

            var block4 = new CompositePlace();
            block4.AddPlace(street1);
            block4.AddPlace(street2);
            block4.AddPlace(street5);
            block4.AddPlace(corner1);
            block4.AddPlace(corner6);

            var block5 = new CompositePlace();
            block5.AddPlace(street1);
            block5.AddPlace(street2);
            block5.AddPlace(street5);
            block5.AddPlace(street6);
            block5.AddPlace(corner1);
            block5.AddPlace(corner6);
            block5.AddPlace(corner2);
            block5.AddPlace(corner7);

            var block6 = new CompositePlace();
            block6.AddPlace(street1);
            block6.AddPlace(street2);
            block6.AddPlace(street6);
            block6.AddPlace(street7);
            block6.AddPlace(corner2);
            block6.AddPlace(corner3);
            block6.AddPlace(corner7);
            block6.AddPlace(corner8);
            block6.AddPlace(square2);

            var neighborhoodA = new CompositePlace();
            neighborhoodA.AddPlace(block1);
            neighborhoodA.AddPlace(block2);
            neighborhoodA.AddPlace(block3);

            // NeighborhoodB: 7 blocks, 1 square

            // Blocks
            block1 = new CompositePlace();
            block1.AddPlace(street1);
            block1.AddPlace(street8);
            block1.AddPlace(corner4);

            block2 = new CompositePlace();
            block2.AddPlace(street1);
            block2.AddPlace(street8);
            block2.AddPlace(street9);
            block2.AddPlace(corner4);
            block2.AddPlace(corner5);

            block3 = new CompositePlace();
            block3.AddPlace(street1);
            block3.AddPlace(street2);
            block3.AddPlace(street8);
            block3.AddPlace(corner4);
            block3.AddPlace(corner9);
            block3.AddPlace(square3);

            block4 = new CompositePlace();
            block4.AddPlace(street1);
            block4.AddPlace(street2);
            block4.AddPlace(street8);
            block4.AddPlace(street9);
            block4.AddPlace(corner4);
            block4.AddPlace(corner5);
            block4.AddPlace(corner9);
            block4.AddPlace(corner10);
            block4.AddPlace(square4);

            var neighborhoodB = new CompositePlace();
            neighborhoodA.AddPlace(block1);
            neighborhoodA.AddPlace(block2);
            neighborhoodA.AddPlace(block3);
            neighborhoodA.AddPlace(block4);

            // NeighborhoodC: 5 blocks, 2 square
            var neighborhoodC = new CompositePlace();

            // NeighborhoodD: 6 blocks
            var neighborhoodD = new CompositePlace();

            var city = new CompositePlace();
            city.AddPlace(neighborhoodA);
            city.AddPlace(neighborhoodB);
            #endregion mocks

            elictrician.changeBurntLamps(city);
        }

        static void Decorator()
        {
            var fireman = new Firefighter();
            //var square = new Square("San Martin", 9, 5, 4);
            var house = new House(102, 9, 1, new mixedBuilder());
            var street = new Street(110, 64, 15);
            house.Street = street;
            house.AddObserver(fireman);
            house.Spark();
        }

        static void Command()
        {
            var places = new List<IPatrol>();
            var cop = new Cop();
            places = CreateMockPlaces(15);

            for (int i = 0; i < places.Count; i++)
            {
                if (i == 5)
                {
                    cop.ChangeOrder(new PursueCriminal());
                }
                else if (i == 10)
                {
                    cop.ChangeOrder(new RequestBackup());
                }
                cop.PatrolStreet(places[i]);
            }
        }

        static void TemplateMethod()
        {
            var doctor = new Medic(new RCPTypeB());
            var passerby = new Passerby();
            doctor.TreatingHeartAttack(passerby);

        }

        static void Adapter()
        {
            var doctor = new Medic(new RCPTypeA());
            var foreignPasserby = new ForeignPasserby(pc: 0.20, pb: 0.30, phr: 0.50);
            var passerby = new ForeignPasserbyAdapter(foreignPasserby);
            doctor.TreatingHeartAttack(passerby);
        }

        static void Builder()
        {
            var fireman = new Firefighter();
            var street = new Street(110, 64, 25);
            var street2 = new Street(110, 64, 10);

            var simpleDeco = new BasicBuilder();
            var mixedDeco = new mixedBuilder();
            var favoDeco = new FavorableBuilder();
            var unfavoDeco = new UnfavorableBuilder();

            var house1 = new House(101, 16, 5, mixedDeco);
            house1.Street = street;
            var house2 = new House(102, 9, 3, favoDeco);
            house2.Street = street2;
            var square1 = new Square("Plaza1", 16, 10, 2, unfavoDeco);
            square1.Street = street;
            var square2 = new Square("Plaza2", 25, 20, 10, simpleDeco);
            square2.Street = street2;

            house1.AddObserver(fireman);
            house2.AddObserver(fireman);
            square1.AddObserver(fireman);
            square2.AddObserver(fireman);

            square1.Spark();
        }

        static List<IPatrol> CreateMockPlaces(int howMany)
        {
            var list = new List<IPatrol>();

            for (int i = 0; i < howMany; i++)
            {
                var option = GenerateRandomValue.GetRandom(0, 3);

                IPatrol place;
                switch (option)
                {
                    case 0:
                        place = new StreetCorner(GenerateRandomValue.GetRandom(0, 5));
                        list.Add(place);
                        break;
                    case 1:
                        place = new House(GenerateRandomValue.GetRandom(0, 999), GenerateRandomValue.GetRandom(0, 65), GenerateRandomValue.GetRandom(0, 9));
                        list.Add(place);
                        break;
                    case 2:
                        place = new Square("", GenerateRandomValue.GetRandom(), GenerateRandomValue.GetRandom(0, 65), GenerateRandomValue.GetRandom(0, 9));
                        list.Add(place);
                        break;
                }
            }

            return list;
        }

        static IQuarter CreateHeroe(IHeroesFactory factory)
        {
            var quarter = factory.CreateQuarter();
            quarter.AddResponsable(factory.CreateHeroe());
            quarter.AddTool(factory.CreateTool());
            quarter.AddVehicle(factory.CreateVehicle());

            return quarter;
        }
    }
}