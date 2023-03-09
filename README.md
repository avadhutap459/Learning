# HomeDownload toast.css
Download toast.css
March 01, 2011
.blazored-toast-container {
    display: flex;
    flex-direction: column;
    position: fixed;
    z-index: 1;
}

.position-topleft,
.position-topright,
.position-topcenter {
    top: 0;
}

.position-bottomleft,
.position-bottomright,
.position-bottomcenter {
    bottom: 0;
}

.blazored-toast {
    display: flex;
    flex-direction: row;
    animation: fadein 1.5s;
    margin-bottom: 1rem;
    padding: 1rem 1.25rem;
    color: #fff;
    width: 100vw;
    box-shadow: rgba(0,0,0,0.25) 0px 10px 40px;
}

.blazored-toast-info {
    background-color: #34a9ad;
}

.blazored-toast-success {
    background-color: #5fba7d;
}

.blazored-toast-warning {
    background-color: #c1c13e;
}

.blazored-toast-error {
    background-color: #ba5e5e;
}

.blazored-toast-icon {
    display: flex;
    flex-direction: column;
    justify-content: center;
    padding: 0 1rem 0 0;
    font-size: 2.5rem;
}

.blazored-toast-body {
    display: flex;
    flex-direction: column;
    flex: 1;
}

    .blazored-toast-body .blazored-toast-header {
        display: flex;
        align-items: flex-start;
        justify-content: space-between;
    }

        .blazored-toast-body .blazored-toast-header h5 {
            font-weight: bold;
            text-transform: uppercase;
            font-size: 1.5rem;
            margin-bottom: 0;
            line-height: 32px;
        }

        .blazored-toast-body .blazored-toast-header .blazored-toast-close {
            background-color: transparent;
            border: 0;
            -webkit-appearance: none;
            color: inherit;
            font-size: 1.25rem;
        }

    .blazored-toast-body p {
        margin-bottom: 0;
        font-size: 1rem;
    }

@keyframes fadein {
    from {
        opacity: 0;
    }

    to {
        opacity: 1;
    }
}

@media (min-width: 576px) {

    .position-topleft {
        top: 2rem;
        left: 2rem;
    }

    .position-topright {
        top: 2rem;
        right: 2rem;
    }

    .position-topcenter {
        top: 2rem;
        left: 50%;
        margin-left: -15rem;
    }

    .position-bottomleft {
        bottom: 2rem;
        left: 2rem;
    }

    .position-bottomright {
        bottom: 2rem;
        right: 2rem;
    }

    .position-bottomcenter {
        bottom: 2rem;
        left: 50%;
        margin-left: -15rem;
    }

    .blazored-toast {
        width: 30rem;
        border-radius: .25rem;
    }
}
