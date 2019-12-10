import React, { Component } from 'react';
import { makeStyles } from '@material-ui/core/styles';
import Card from '@material-ui/core/Card';
import CardActionArea from '@material-ui/core/CardActionArea';
import CardActions from '@material-ui/core/CardActions';
import CardContent from '@material-ui/core/CardContent';
import CardMedia from '@material-ui/core/CardMedia';
import Button from '@material-ui/core/Button';
import Typography from '@material-ui/core/Typography';

const useStyles = makeStyles({
    card: {
        maxWidth: 345,
        margin: 20,
    },
    media: {
        height: 140,
    },
});

export default class ListItemCar extends Component {
    render() {
        const {
            registryNumber,
            brand,
            manufacturer,
            engineVolume,
            enginePower,
            fuelConsumption,
            doorsNumber,
            seatsNumber,
            volumeTrunk,
            automaticTransmission,
            cruiseControl,
            fuel,
            conditioner,
            radio,
            video,
            gpsNavigator,
            interior,
            color,
            milage,
            to,
            price,
            client,
            handleClickEditOpen,
            onDeleted,
            handleClickOpenMore
        } = this.props;
        const classes = useStyles();
        return(
            <Card className={classes.card}>
                <CardActionArea>
                    <CardMedia
                        className={classes.media}
                        image="/static/images/cards/contemplative-reptile.jpg"
                        title="Contemplative Reptile"
                    />
                    <CardContent>
                        <Typography gutterBottom variant="h5" component="h2">
                            {brand}
                        </Typography>
                        <Typography variant="body2" color="textSecondary" component="p">
                            {manufacturer}
                        </Typography>
                        <Typography variant="body2" color="textSecondary" component="p">
                            {price}
                        </Typography>
                        <Typography variant="body2" color="textSecondary" component="p">
                            {automaticTransmission}
                        </Typography>
                        <Typography variant="body2" color="textSecondary" component="p">
                            {registryNumber}
                        </Typography>
                        <Typography variant="body2" color="textSecondary" component="p">
                            {doorsNumber}
                        </Typography>
                        <Typography variant="body2" color="textSecondary" component="p">
                            {fuel}
                        </Typography>
                        <Typography variant="body2" color="textSecondary" component="p">
                            {color}
                        </Typography>
                        <Typography variant="body2" color="textSecondary" component="p">
                            {enginePower}
                        </Typography>
                        <Typography variant="body2" color="textSecondary" component="p">
                            {fuelConsumption}
                        </Typography>
                        <Typography variant="body2" color="textSecondary" component="p">
                            {seatsNumber}
                        </Typography>
                    </CardContent>
                </CardActionArea>
                <CardActions>
                    <Button size="small" color="primary">
                        Share
                    </Button>
                    <Button size="small" color="primary">
                        Learn More
                    </Button>
                </CardActions>
            </Card>
        )
    }
}
