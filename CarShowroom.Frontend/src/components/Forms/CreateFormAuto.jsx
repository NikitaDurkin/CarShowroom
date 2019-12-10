import React from 'react';
import { Form, Field } from 'react-final-form';
import PropTypes from 'prop-types';
import Button from '@material-ui/core/Button';
import DialogActions from '@material-ui/core/DialogActions';
import DialogContent from '@material-ui/core/DialogContent';

const CreateFormAuto = ({ onSubmit, handleClose }) => (
    <Form
        onSubmit={onSubmit}     //передаём этот props в render в handelSubmit
        render={({ handleSubmit }) => (
            <form onSubmit={handleSubmit}>
                <DialogContent className="input-group-modal">
                    <div>
                        <label>Регистрационный номер:</label>
                        <Field required name="registryNumber" component="input" type="text" />
                    </div>
                    <div>
                        <label>Марка:</label>
                        <Field required name="brand" component="input" type="text" />
                    </div>
                    <div>
                        <label>Производитель:</label>
                        <Field required name="manufacturer" component="input" type="text" />
                    </div>
                    <div>
                        <label>Объем двигателя:</label>
                        <Field name="engineVolume" component="input" type="text" />
                    </div>
                    <div>
                        <label>Мощность двигателя:</label>
                        <Field required name="enginePower" component="input" type="text" />
                    </div>
                    <div>
                        <label>Расход топлива:</label>
                        <Field required name="fuelConsumption" component="input" type="text"
                        />
                    </div>
                    <div>
                        <label>Количество дверей:</label>
                        <Field required name="doorsNumber" component="input" type="text" />
                    </div>
                    <div>
                        <label>Число посадочных мест:</label>
                        <Field required name="seatsNumber" component="input" type="text" />
                    </div>
                    <div>
                        <label>Объем багажника:</label>
                        <Field required name="volumeTrunk" component="input" type="text" />
                    </div>
                    <div>
                        <label>КПП автомат:</label>
                        <Field required name="automaticTransmission" component="input" type="checkbox" />
                    </div>
                    <div>
                        <label>Круиз контроль:</label>
                        <Field required name="cruiseControl" component="input" type="checkbox" />
                    </div>
                    <div>
                        <label>Топливо:</label>
                        <Field required name="fuel" component="input" type="text" />
                    </div>
                    <div>
                        <label>Наличие кондиционера:</label>
                        <Field required name="conditioner" component="input" type="checkbox" />
                    </div>
                    <div>
                        <label>Наличие радио:</label>
                        <Field required name="radio" component="input" type="checkbox" />
                    </div>
                    <div>
                        <label>Наличие видео:</label>
                        <Field required name="video" component="input" type="checkbox" />
                    </div>
                    <div>
                        <label>GPS навигатор:</label>
                        <Field required name="gpsNavigator" component="input" type="checkbox" />
                    </div>
                    <div>
                        <label>Материал обивки:</label>
                        <Field required name="interior" component="input" type="text" />
                    </div>
                    <div>
                        <label>Цвет:</label>
                        <Field required name="color" component="input" type="text" />
                    </div>
                    <div>
                        <label>Пробег:</label>
                        <Field required name="milage" component="input" type="text" />
                    </div>
                    <div>
                        <label>Техосмотр:</label>
                        <Field required name="to" component="input" type="text" />
                    </div>
                    <div>
                        <label>Цена:</label>
                        <Field required name="price" component="input" type="text" />
                    </div>
                    <div>
                        <label>Клиенты проводившие тест драйв:</label>
                        <Field required name="client" component="input" type="text" />
                    </div>
                </DialogContent>
                <DialogActions>
                    <Button type="submit" color="primary">
                        Добавить автомобиль
                    </Button>
                    <Button onClick={handleClose} color="primary" autoFocus>
                        Отменить
                    </Button>
                </DialogActions>
            </form>
        )}
    />
);

CreateFormAuto.propTypes = {
    onSubmit: PropTypes.func,
    handleClose: PropTypes.func
};

export default CreateFormAuto;
