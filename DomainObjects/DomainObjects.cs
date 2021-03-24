using System;
using System.Collections.Generic;

namespace DomainObjects
{
    /// <summary>
    /// Борт
    /// </summary>
    public class PlaneBoard
    {
        //Идентификатор
        public Int64 Id { get; set; }
        //Системное имя типа ВС
        public String PlaneType { get; set; }
        //Системное имя борта
        public String PlaneBoardNo { get; set; }
        //Список полётов борта
        public virtual IList<PlaneFlight> Flights { get; set; }
    }

    /// <summary>
    /// Полёт
    /// </summary>
    public class PlaneFlight
    {
        //Идентификатор
        public Int64 Id { get; set; }
        //Дата полёта
        public DateTime FlightDate { get; set; }
        //Смена        
        public Int16 FlightSmena { get; set; }
        //Номер вылета
        public Int32 FlightNo { get; set; }
        //Позывной лётчика
        public String PilotName { get; set; }
        //Идентификатор борта
        public Int64 PlaneBoardId { get; set; }
        //Борт
        public virtual PlaneBoard PlaneBoard { get; set; }
    }
}
