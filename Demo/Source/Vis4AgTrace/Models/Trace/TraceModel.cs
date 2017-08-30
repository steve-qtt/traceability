using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VisDAL;

namespace Vis4AgTrace.Models.Trace
{
    public enum TraceType
    {
        ToSource,
        ToDestination
    }

    public class TraceModel
    {
        private Guid _containerID;
        private Guid _loadID;
        private string _traceType;
        private List<LoadEvent> _loadEvents;
        private List<LoadEvent> _unloadEvents;

        public List<Container> Containers { get; private set; }

        public List<Load> Loads { get; private set; }

        public List<LoadEvent> LoadEvents 
        {
            get { return _loadEvents;  }
            private set { }
        }


        public List<LoadEvent> UnloadEvents
        {
            get { return _unloadEvents; }
            private set { }
        }

        public Guid SelectedContainer
        {
           get {
                if (_containerID == null)
                    return Guid.Empty;
                else
                    return _containerID;
           }
           set {
                _containerID = value;
            }
        }

        public Guid SelectedLoad
        {
            get
            {
                if (_loadID == null)
                    return Guid.Empty;
                else
                    return _loadID;
            }
            set {
                _loadID = value;
            }
        }

        public TraceType TraceType
        {
            get
            {
                if (_traceType == "Source") return TraceType.ToSource;
                if (_traceType == "Destination") return TraceType.ToDestination;
                return TraceType.ToSource;
            }
            private set { }
        }

        public TraceModel()
        {
            Init();
        }


        public TraceModel(Guid containerID)
        {
            Init();

            this._containerID = containerID;
        }

        public TraceModel(Guid containerID, Guid loadID, string traceType)
        {
            Init();

            this._containerID = containerID;
            this._loadID = loadID;
            this._traceType = traceType;

            this._loadEvents = FilterLoadEvents(SelectedLoad);
            this._unloadEvents = FilterUnloadEvents(SelectedLoad);
        }

        private void Init()
        {
            //Fill the Containers and Loads lists so that they are in memory
            using (VisDBDataContext context = new VisDBDataContext())
            {
                Containers = context.Containers.ToList();
                Loads = context.Loads.ToList();
            }
        }

        private List<LoadEvent> FilterLoadEvents(Guid selectedLoadId)
        {
            using (VisDBDataContext context = new VisDBDataContext())
            {
               return context.LoadEvents.Where(le => le.LoadID == selectedLoadId && le.EventTypeID == 1).ToList();
            }
        }

        private List<LoadEvent> FilterUnloadEvents(Guid selectedLoadId)
        {
            using (VisDBDataContext context = new VisDBDataContext())
            {
                return context.LoadEvents.Where(le => le.LoadID == selectedLoadId && le.EventTypeID == 2).ToList();
            }
        }
    }
}