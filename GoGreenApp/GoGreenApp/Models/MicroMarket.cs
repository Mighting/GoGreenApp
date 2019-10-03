using System;
using System.Collections.Generic;
using System.Text;

namespace GoGreenApp.Models
{
    public class MicroMarket
    {
        private int MicroMarketId;
        private int ZipCodeID;
        private DateTime OrderHoursStart;
        private DateTime OrderHoursEnd;
        private DateTime OpeningHoursStart;
        private DateTime OpeningHoursEnd;
        private String streetName;
        private String houseNumber;
        private int floorNumber;
        private String phoneNumber;
        private String email;
        private String firstName;
        private String lastName;
        private int Active;

        public MicroMarket()
        {
        }

        public DateTime getOpeningHoursStart()
        {
            return OpeningHoursStart;
        }

        public void setOpeningHoursStart(DateTime openingHoursStart)
        {
            OpeningHoursStart = openingHoursStart;
        }

        public DateTime getOpeningHoursEnd()
        {
            return OpeningHoursEnd;
        }

        public void setOpeningHoursEnd(DateTime openingHoursEnd)
        {
            OpeningHoursEnd = openingHoursEnd;
        }

        public DateTime getOrderHoursEnd()
        {
            return OrderHoursEnd;
        }

        public void setOrderHoursEnd(DateTime orderHoursEnd)
        {
            OrderHoursEnd = orderHoursEnd;
        }

        public DateTime getOrderHoursStart()
        {
            return OrderHoursStart;
        }

        public void setOrderHoursStart(DateTime orderHoursStart)
        {
            OrderHoursStart = orderHoursStart;
        }

        public String getStreetName()
        {
            return streetName;
        }

        public void setStreetName(String streetName)
        {
            this.streetName = streetName;
        }

        public String getHouseNumber()
        {
            return houseNumber;
        }

        public void setHouseNumber(String houseNumber)
        {
            this.houseNumber = houseNumber;
        }

        public int getFloorNumber()
        {
            return floorNumber;
        }

        public void setFloorNumber(int floorNumber)
        {
            this.floorNumber = floorNumber;
        }

        public String getPhoneNumber()
        {
            return phoneNumber;
        }

        public void setPhoneNumber(String phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        public String getEmail()
        {
            return email;
        }

        public void setEmail(String email)
        {
            this.email = email;
        }

        public String getFirstName()
        {
            return firstName;
        }

        public void setFirstName(String firstName)
        {
            this.firstName = firstName;
        }

        public String getLastName()
        {
            return lastName;
        }

        public void setLastName(String lastName)
        {
            this.lastName = lastName;
        }

        public int getActive()
        {
            return Active;
        }

        public void setActive(int active)
        {
            Active = active;
        }

        public int getMicroMarketId()
        {
            return MicroMarketId;
        }

        public void setMicroMarketId(int microMarketId)
        {
            MicroMarketId = microMarketId;
        }

        public int getZipCodeID()
        {
            return ZipCodeID;
        }

        public void setZipCodeID(int zipCodeID)
        {
            ZipCodeID = zipCodeID;
        }

    }

}
