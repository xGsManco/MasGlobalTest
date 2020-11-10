import React, { Component } from 'react';

export class FetchData extends Component {
    static displayName = FetchData.name;

    constructor(props) {
        super(props);
        this.state = { idToSearch: "", employees: [], loading: true };

        this.handleSearchClick = this.handleSearchClick.bind(this);
        this.handleInputSearchChange = this.handleInputSearchChange.bind(this);
    }

    handleInputSearchChange(event) {        
        this.setState({ idToSearch: event.target.value });
    }

    handleSearchClick() {
        this.populateEmployeeData();
    }

    componentDidMount() {
        this.populateEmployeeData();
    }

    static renderEmployeesTable(employees,currentThis) {
        return (
            <React.Fragment>
                <div className="input-group mb-3">
                    <input onChange={currentThis.handleInputSearchChange} type="text" className="form-control" placeholder="Id to search" aria-label="Id to search" aria-describedby="basic-addon2" />
                    <div className="input-group-append">
                        <button onClick={currentThis.handleSearchClick} className="btn btn-outline-secondary" type="button">Search</button>
                    </div>
                </div>
                <table className='table table-striped' aria-labelledby="tabelLabel">
                    <thead>
                        <tr>
                            <th>Name</th>
                            <th>Role</th>
                            <th>Hour</th>
                            <th>Month</th>
                            <th>Anual</th>
                        </tr>
                    </thead>
                    <tbody>
                        {employees.map(employee =>
                            <tr key={employee.id}>
                                <td>{employee.name}</td>
                                <td>{employee.roleName}</td>
                                <td>{employee.hourlySalary}</td>
                                <td>{employee.monthlySalary}</td>
                                <td>{employee.anualSalary}</td>
                            </tr>
                        )}
                    </tbody>
                </table>
            </React.Fragment>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : FetchData.renderEmployeesTable(this.state.employees,this);

        return (
            <div>
                <h1 id="tabelLabel" >Employees</h1>
                <p>This is the Yeison Manco's Test for MAS Global</p>
                {contents}
            </div>
        );
    }

    

    async populateEmployeeData() {

        let route = this.state.idToSearch ? "/" + this.state.idToSearch : "";
        const response = await fetch('api/employees' + route);
        const data = await response.json();
        this.setState({ employees: data, loading: false });
    }
}
