import React, { Component, Fragment } from 'react';
import { connect } from 'react-redux';
import './index.css';

import Home from '../Header'
import About from '../Header'
import Users from '../Header'
import Header from '../Header';
import ListCar from '../ListCar';
import Dialog from '@material-ui/core/Dialog';
import DialogTitle from '@material-ui/core/DialogTitle';
import  CreateFormAuto  from '../Forms/CreateFormAuto'

import { getCars, createCar } from '../../utils';

class Admin extends Component {
    state = {
        carData: [],
        isOpen: false,
        isOpenEdit: false,
        isOpenMore: false,
        detailCar: {}
    }

    componentDidMount() {
        getCars.then(res => {
            this.setState({ carData: res.data });
        });
    }

    handleClickOpen = () => {
        this.setState({ isOpen: true });
    };
    handleClose = () => {
        this.setState({ isOpen: false });
    };
    submitCreateCar = values => {
        console.log('values', values);
        createCar(values).then(res => {
            this.setState(state => ({
                clinicData: state.carData.concat({
                    ...values,
                    registryNumber: res.data
                }),
                isOpen: false
            }));
        });
    };

    render() {
    const { carData, isOpen, isOpenEdit, isOpenMore, detailCar } = this.state;
    const { submitCreateCar, handleClickOpen, handleClose } = this.props;
        return (
                <Fragment>
                    <button className="add" onClick={this.handleClickOpen}>
                        Добавить автомобиль
                    </button>
                    <Dialog
                        open={isOpen}
                        onClose={this.handleClose}
                        aria-labelledby="alert-dialog-title"
                        aria-describedby="alert-dialog-description"
                    >
                            <DialogTitle id="alert-dialog-title">Добавить автомобиль</DialogTitle>
                            <CreateFormAuto onSubmit={this.submitCreateCar} handleClose={this.handleClose} />
                    </Dialog>

                    <ListCar
                        data={ carData }
                    />

                </Fragment>
        )
    }
}

const mapStateToProps = (state) => {
    return(
        {
            cars: state.reducersCars.cars,
        }
    )
}

const mapDispatchToProps = dispatch => ({

});

export default connect(mapStateToProps, mapDispatchToProps)(Admin);
