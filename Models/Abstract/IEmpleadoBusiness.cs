using CRUD.Clases;
using CRUD.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRUD.Models.Abstract
{
    public interface IEmpleadoBusiness
    {
        Task guardarEmpleado(Empleado empleado);
        Task eliminarEmpleado(Empleado empleado);
        Task<IEnumerable<EmpleadoDetalle>> obtenerEmpleadosTodos();
        Task<Empleado> obtenerEmpleadoPorID(int? id);
        Task<List<CargoEmpleado>> obtenerCargoTodos();
        Task<IEnumerable<EmpleadoDetalle>> obtenerEmpleadosPorNombrePorId(string busqueda);

    }
}



