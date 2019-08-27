
//-----------------------------------------------------------------------
// <auto-generated />
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Tasks.Docker.Engine;

namespace FlubuCore.Context.FluentInterface.Docker
{
    public class Engine
    {  
        
            
        /// <summary>
        /// Activate Enterprise Edition
        /// </summary>
            public DockerEngineActivateTask EngineActivate()
            {
                return new DockerEngineActivateTask();
            }


            
        /// <summary>
        /// Check for available engine updates
        /// </summary>
            public DockerEngineCheckTask EngineCheck()
            {
                return new DockerEngineCheckTask();
            }


            
        /// <summary>
        /// Update a local engine
        /// </summary>
            public DockerEngineUpdateTask EngineUpdate()
            {
                return new DockerEngineUpdateTask();
            }

        
    }
}

