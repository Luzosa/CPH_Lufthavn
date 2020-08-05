Select FlightCompanyName AS "Company", StartingLocation AS "Flight Departure", Destination AS "Flight Destination" From Destinations
INNER JOIN Dest_Flight ON Destinations.DestinationID = Dest_Flight.Destination_FK 
INNER JOIN Airplanes ON Dest_Flight.Airplanes_FK = Airplanes.AirplanesId
INNER JOIN FlightCompany ON Airplanes.FlightCompany_FK = FlightCompany.FlightCompanyID;
