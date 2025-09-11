--
-- PostgreSQL database dump
--

\restrict 3Z9tBV2xEwFosSeXKwnbcPfhGdny55irS8bOadDvSchfcmfVwd0oWt1n0s382wk

-- Dumped from database version 17.6
-- Dumped by pg_dump version 17.6

-- Started on 2025-09-10 14:51:54

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET transaction_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- TOC entry 6 (class 2615 OID 17041)
-- Name: meta; Type: SCHEMA; Schema: -; Owner: postgres
--

CREATE SCHEMA meta;


ALTER SCHEMA meta OWNER TO postgres;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 218 (class 1259 OID 17042)
-- Name: migrations; Type: TABLE; Schema: meta; Owner: postgres
--

CREATE TABLE meta.migrations (
    version text NOT NULL,
    name text,
    applied_at timestamp with time zone DEFAULT now() NOT NULL
);


ALTER TABLE meta.migrations OWNER TO postgres;

--
-- TOC entry 219 (class 1259 OID 17048)
-- Name: almacenes; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.almacenes (
    id bigint NOT NULL,
    nombre text NOT NULL,
    ubicacion text
);


ALTER TABLE public.almacenes OWNER TO postgres;

--
-- TOC entry 220 (class 1259 OID 17053)
-- Name: almacenes_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.almacenes ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.almacenes_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 221 (class 1259 OID 17054)
-- Name: caja; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.caja (
    id bigint NOT NULL,
    gastos numeric(12,2),
    entrada_dinero numeric(12,2),
    salida_dinero numeric(12,2),
    pagos numeric(12,2),
    impuestos numeric(12,2),
    ventas_dia numeric(12,2),
    fecha date,
    idusuario bigint,
    CONSTRAINT caja_entrada_dinero_check CHECK ((entrada_dinero >= (0)::numeric)),
    CONSTRAINT caja_gastos_check CHECK ((gastos >= (0)::numeric)),
    CONSTRAINT caja_impuestos_check CHECK ((impuestos >= (0)::numeric)),
    CONSTRAINT caja_pagos_check CHECK ((pagos >= (0)::numeric)),
    CONSTRAINT caja_salida_dinero_check CHECK ((salida_dinero >= (0)::numeric)),
    CONSTRAINT caja_ventas_dia_check CHECK ((ventas_dia >= (0)::numeric))
);


ALTER TABLE public.caja OWNER TO postgres;

--
-- TOC entry 222 (class 1259 OID 17063)
-- Name: caja_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.caja ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.caja_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 223 (class 1259 OID 17064)
-- Name: cliente; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.cliente (
    id bigint NOT NULL,
    nombre text NOT NULL,
    direccion text,
    ciudad text,
    telefono text,
    cuit text,
    dni text,
    condicion_iva text
);


ALTER TABLE public.cliente OWNER TO postgres;

--
-- TOC entry 224 (class 1259 OID 17069)
-- Name: cliente_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.cliente ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.cliente_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 225 (class 1259 OID 17070)
-- Name: combopromocion; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.combopromocion (
    id bigint NOT NULL,
    idpromocion bigint,
    idproducto bigint,
    cantidad integer,
    descuento numeric(5,2)
);


ALTER TABLE public.combopromocion OWNER TO postgres;

--
-- TOC entry 226 (class 1259 OID 17073)
-- Name: combopromocion_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.combopromocion ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.combopromocion_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 227 (class 1259 OID 17074)
-- Name: detalleventas; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.detalleventas (
    id bigint NOT NULL,
    idventa bigint,
    idproducto bigint,
    cantidad integer,
    precio_unitario numeric(12,2),
    descuento numeric(5,2),
    subtotal_linea numeric(12,2),
    iva_percent numeric(5,2),
    monto_iva numeric(12,2),
    descuento_percent numeric(5,2),
    precio_costo_snapshot numeric(12,2),
    total_linea numeric(12,2),
    CONSTRAINT detalleventas_descuento_percent_check CHECK (((descuento_percent >= (0)::numeric) AND (descuento_percent <= (100)::numeric))),
    CONSTRAINT detalleventas_iva_percent_check CHECK (((iva_percent >= (0)::numeric) AND (iva_percent <= (100)::numeric))),
    CONSTRAINT detalleventas_monto_iva_check CHECK ((monto_iva >= (0)::numeric)),
    CONSTRAINT detalleventas_precio_costo_snapshot_check CHECK ((precio_costo_snapshot >= (0)::numeric)),
    CONSTRAINT detalleventas_precio_unitario_check CHECK ((precio_unitario >= (0)::numeric)),
    CONSTRAINT detalleventas_subtotal_linea_check CHECK ((subtotal_linea >= (0)::numeric)),
    CONSTRAINT detalleventas_total_linea_check CHECK ((total_linea >= (0)::numeric))
);


ALTER TABLE public.detalleventas OWNER TO postgres;

--
-- TOC entry 228 (class 1259 OID 17084)
-- Name: detalleventas_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.detalleventas ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.detalleventas_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 229 (class 1259 OID 17085)
-- Name: devoluciones; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.devoluciones (
    id bigint NOT NULL,
    idventa bigint,
    iddetalle bigint,
    cantidad integer,
    motivo text,
    fecha timestamp with time zone DEFAULT now(),
    CONSTRAINT devoluciones_cantidad_check CHECK ((cantidad >= 0))
);


ALTER TABLE public.devoluciones OWNER TO postgres;

--
-- TOC entry 230 (class 1259 OID 17092)
-- Name: devoluciones_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.devoluciones ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.devoluciones_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 231 (class 1259 OID 17093)
-- Name: formaspago; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.formaspago (
    id bigint NOT NULL,
    metodo text NOT NULL
);


ALTER TABLE public.formaspago OWNER TO postgres;

--
-- TOC entry 232 (class 1259 OID 17098)
-- Name: formaspago_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.formaspago ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.formaspago_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 233 (class 1259 OID 17099)
-- Name: historialprecio; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.historialprecio (
    id bigint NOT NULL,
    precioanterior numeric(10,2),
    precioactual numeric(10,2),
    fecha date,
    costoanterior numeric(10,2),
    costoactual numeric(10,2),
    idproducto bigint,
    idventa bigint
);


ALTER TABLE public.historialprecio OWNER TO postgres;

--
-- TOC entry 234 (class 1259 OID 17102)
-- Name: historialprecio_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.historialprecio ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.historialprecio_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 235 (class 1259 OID 17103)
-- Name: listasprecios; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.listasprecios (
    id bigint NOT NULL,
    tipo text NOT NULL,
    porcentajedescuento numeric(5,2),
    CONSTRAINT listasprecios_tipo_check CHECK ((tipo = ANY (ARRAY['profesional'::text, 'revendedor'::text, 'local'::text])))
);


ALTER TABLE public.listasprecios OWNER TO postgres;

--
-- TOC entry 236 (class 1259 OID 17109)
-- Name: listasprecios_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.listasprecios ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.listasprecios_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 237 (class 1259 OID 17110)
-- Name: movimientoscaja; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.movimientoscaja (
    id bigint NOT NULL,
    tipo_operacion text,
    monto numeric(10,2),
    idusuario bigint,
    fecha date,
    CONSTRAINT movimientoscaja_tipo_operacion_check CHECK ((tipo_operacion = ANY (ARRAY['gasto'::text, 'ingreso'::text, 'pago'::text, 'impuesto'::text, 'otro'::text])))
);


ALTER TABLE public.movimientoscaja OWNER TO postgres;

--
-- TOC entry 238 (class 1259 OID 17116)
-- Name: movimientoscaja_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.movimientoscaja ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.movimientoscaja_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 239 (class 1259 OID 17117)
-- Name: pagos; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.pagos (
    id bigint NOT NULL,
    idventa bigint,
    idformapago bigint,
    monto numeric(10,2)
);


ALTER TABLE public.pagos OWNER TO postgres;

--
-- TOC entry 240 (class 1259 OID 17120)
-- Name: pagos_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.pagos ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.pagos_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 241 (class 1259 OID 17121)
-- Name: producto_proveedor; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.producto_proveedor (
    id bigint NOT NULL,
    idproducto bigint,
    idproveedor bigint,
    precio_costo numeric(12,2),
    fecha_actualizacion timestamp with time zone DEFAULT now(),
    es_principal boolean DEFAULT false,
    codigo_proveedor text,
    plazo_entrega_dias integer,
    moq integer,
    moneda text,
    activo boolean DEFAULT true,
    CONSTRAINT producto_proveedor_moq_check CHECK ((moq >= 0)),
    CONSTRAINT producto_proveedor_plazo_entrega_dias_check CHECK ((plazo_entrega_dias >= 0)),
    CONSTRAINT producto_proveedor_precio_costo_check CHECK ((precio_costo >= (0)::numeric))
);


ALTER TABLE public.producto_proveedor OWNER TO postgres;

--
-- TOC entry 242 (class 1259 OID 17132)
-- Name: producto_proveedor_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.producto_proveedor ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.producto_proveedor_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 243 (class 1259 OID 17133)
-- Name: productoproveedor; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.productoproveedor (
    id bigint NOT NULL,
    idproducto bigint,
    idproveedor bigint,
    precio_costo numeric(10,2),
    fecha_costo date
);


ALTER TABLE public.productoproveedor OWNER TO postgres;

--
-- TOC entry 244 (class 1259 OID 17136)
-- Name: productoproveedor_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.productoproveedor ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.productoproveedor_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 245 (class 1259 OID 17137)
-- Name: productos; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.productos (
    id bigint NOT NULL,
    cod text NOT NULL,
    nombre text NOT NULL,
    "tamaño" text,
    recargo numeric(12,2),
    fecha date,
    stock integer,
    iva numeric(12,2),
    marca text,
    observacion text,
    CONSTRAINT productos_iva_check CHECK ((iva >= (0)::numeric)),
    CONSTRAINT productos_recargo_check CHECK ((recargo >= (0)::numeric))
);


ALTER TABLE public.productos OWNER TO postgres;

--
-- TOC entry 246 (class 1259 OID 17144)
-- Name: productos_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.productos ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.productos_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 247 (class 1259 OID 17145)
-- Name: promocionproductos; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.promocionproductos (
    id bigint NOT NULL,
    idproducto bigint,
    descuento numeric(12,2),
    cantidad integer,
    fecha date,
    monto numeric(12,2),
    CONSTRAINT promocionproductos_descuento_check CHECK ((descuento >= (0)::numeric)),
    CONSTRAINT promocionproductos_monto_check CHECK ((monto >= (0)::numeric))
);


ALTER TABLE public.promocionproductos OWNER TO postgres;

--
-- TOC entry 248 (class 1259 OID 17150)
-- Name: promocionproductos_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.promocionproductos ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.promocionproductos_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 249 (class 1259 OID 17151)
-- Name: proveedores; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.proveedores (
    id bigint NOT NULL,
    nombre text NOT NULL,
    ciudad text,
    direccion text,
    email text,
    telefono1 text,
    telefono2 text,
    paginaweb text,
    iva numeric(5,2)
);


ALTER TABLE public.proveedores OWNER TO postgres;

--
-- TOC entry 250 (class 1259 OID 17156)
-- Name: proveedores_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.proveedores ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.proveedores_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 251 (class 1259 OID 17157)
-- Name: roles; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.roles (
    id bigint NOT NULL,
    nombre text NOT NULL
);


ALTER TABLE public.roles OWNER TO postgres;

--
-- TOC entry 252 (class 1259 OID 17162)
-- Name: roles_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.roles ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.roles_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 253 (class 1259 OID 17163)
-- Name: stock_movimientos; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.stock_movimientos (
    id bigint NOT NULL,
    idproducto bigint,
    tipo text,
    cantidad integer,
    referencia_tipo text,
    referencia_id bigint,
    idusuario bigint,
    fecha timestamp with time zone DEFAULT now(),
    idalmacen bigint,
    CONSTRAINT stock_movimientos_cantidad_check CHECK ((cantidad >= 0)),
    CONSTRAINT stock_movimientos_referencia_tipo_check CHECK ((referencia_tipo = ANY (ARRAY['venta'::text, 'compra'::text, 'ajuste'::text]))),
    CONSTRAINT stock_movimientos_tipo_check CHECK ((tipo = ANY (ARRAY['entrada'::text, 'salida'::text, 'ajuste'::text, 'compra'::text, 'venta'::text])))
);


ALTER TABLE public.stock_movimientos OWNER TO postgres;

--
-- TOC entry 254 (class 1259 OID 17172)
-- Name: stock_movimientos_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.stock_movimientos ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.stock_movimientos_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 255 (class 1259 OID 17173)
-- Name: usuario; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.usuario (
    id bigint NOT NULL,
    nombre text NOT NULL,
    dni text NOT NULL,
    tel text,
    mail text,
    password_hash text NOT NULL,
    idrol bigint,
    email text,
    last_login timestamp with time zone,
    is_active boolean DEFAULT true,
    failed_logins integer DEFAULT 0,
    created_at timestamp with time zone DEFAULT now(),
    updated_at timestamp with time zone DEFAULT now()
);


ALTER TABLE public.usuario OWNER TO postgres;

--
-- TOC entry 256 (class 1259 OID 17182)
-- Name: usuario_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.usuario ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.usuario_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 257 (class 1259 OID 17183)
-- Name: ventas; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.ventas (
    id bigint NOT NULL,
    idcliente bigint,
    idusuario bigint,
    fecha date,
    total numeric(12,2),
    numero_comprobante text,
    tipo_comprobante text,
    estado text,
    id_listaprecio bigint,
    moneda text,
    observaciones text,
    created_at timestamp with time zone DEFAULT now(),
    updated_at timestamp with time zone DEFAULT now(),
    CONSTRAINT ventas_estado_check CHECK ((estado = ANY (ARRAY['borrador'::text, 'confirmada'::text, 'anulada'::text]))),
    CONSTRAINT ventas_tipo_comprobante_check CHECK ((tipo_comprobante = ANY (ARRAY['A'::text, 'B'::text, 'C'::text]))),
    CONSTRAINT ventas_total_check CHECK ((total >= (0)::numeric))
);


ALTER TABLE public.ventas OWNER TO postgres;

--
-- TOC entry 258 (class 1259 OID 17193)
-- Name: ventas_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.ventas ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.ventas_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 259 (class 1259 OID 17194)
-- Name: versionbasededatos; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.versionbasededatos (
    id bigint NOT NULL,
    version text NOT NULL,
    fecha date
);


ALTER TABLE public.versionbasededatos OWNER TO postgres;

--
-- TOC entry 260 (class 1259 OID 17199)
-- Name: versionbasededatos_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.versionbasededatos ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.versionbasededatos_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 5004 (class 0 OID 17042)
-- Dependencies: 218
-- Data for Name: migrations; Type: TABLE DATA; Schema: meta; Owner: postgres
--

COPY meta.migrations (version, name, applied_at) FROM stdin;
202407160001	embeddings	2025-09-08 11:32:44.438-03
\.


--
-- TOC entry 5005 (class 0 OID 17048)
-- Dependencies: 219
-- Data for Name: almacenes; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.almacenes (id, nombre, ubicacion) FROM stdin;
\.


--
-- TOC entry 5007 (class 0 OID 17054)
-- Dependencies: 221
-- Data for Name: caja; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.caja (id, gastos, entrada_dinero, salida_dinero, pagos, impuestos, ventas_dia, fecha, idusuario) FROM stdin;
\.


--
-- TOC entry 5009 (class 0 OID 17064)
-- Dependencies: 223
-- Data for Name: cliente; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.cliente (id, nombre, direccion, ciudad, telefono, cuit, dni, condicion_iva) FROM stdin;
\.


--
-- TOC entry 5011 (class 0 OID 17070)
-- Dependencies: 225
-- Data for Name: combopromocion; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.combopromocion (id, idpromocion, idproducto, cantidad, descuento) FROM stdin;
\.


--
-- TOC entry 5013 (class 0 OID 17074)
-- Dependencies: 227
-- Data for Name: detalleventas; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.detalleventas (id, idventa, idproducto, cantidad, precio_unitario, descuento, subtotal_linea, iva_percent, monto_iva, descuento_percent, precio_costo_snapshot, total_linea) FROM stdin;
\.


--
-- TOC entry 5015 (class 0 OID 17085)
-- Dependencies: 229
-- Data for Name: devoluciones; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.devoluciones (id, idventa, iddetalle, cantidad, motivo, fecha) FROM stdin;
\.


--
-- TOC entry 5017 (class 0 OID 17093)
-- Dependencies: 231
-- Data for Name: formaspago; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.formaspago (id, metodo) FROM stdin;
\.


--
-- TOC entry 5019 (class 0 OID 17099)
-- Dependencies: 233
-- Data for Name: historialprecio; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.historialprecio (id, precioanterior, precioactual, fecha, costoanterior, costoactual, idproducto, idventa) FROM stdin;
\.


--
-- TOC entry 5021 (class 0 OID 17103)
-- Dependencies: 235
-- Data for Name: listasprecios; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.listasprecios (id, tipo, porcentajedescuento) FROM stdin;
\.


--
-- TOC entry 5023 (class 0 OID 17110)
-- Dependencies: 237
-- Data for Name: movimientoscaja; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.movimientoscaja (id, tipo_operacion, monto, idusuario, fecha) FROM stdin;
\.


--
-- TOC entry 5025 (class 0 OID 17117)
-- Dependencies: 239
-- Data for Name: pagos; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.pagos (id, idventa, idformapago, monto) FROM stdin;
\.


--
-- TOC entry 5027 (class 0 OID 17121)
-- Dependencies: 241
-- Data for Name: producto_proveedor; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.producto_proveedor (id, idproducto, idproveedor, precio_costo, fecha_actualizacion, es_principal, codigo_proveedor, plazo_entrega_dias, moq, moneda, activo) FROM stdin;
\.


--
-- TOC entry 5029 (class 0 OID 17133)
-- Dependencies: 243
-- Data for Name: productoproveedor; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.productoproveedor (id, idproducto, idproveedor, precio_costo, fecha_costo) FROM stdin;
\.


--
-- TOC entry 5031 (class 0 OID 17137)
-- Dependencies: 245
-- Data for Name: productos; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.productos (id, cod, nombre, "tamaño", recargo, fecha, stock, iva, marca, observacion) FROM stdin;
\.


--
-- TOC entry 5033 (class 0 OID 17145)
-- Dependencies: 247
-- Data for Name: promocionproductos; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.promocionproductos (id, idproducto, descuento, cantidad, fecha, monto) FROM stdin;
\.


--
-- TOC entry 5035 (class 0 OID 17151)
-- Dependencies: 249
-- Data for Name: proveedores; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.proveedores (id, nombre, ciudad, direccion, email, telefono1, telefono2, paginaweb, iva) FROM stdin;
\.


--
-- TOC entry 5037 (class 0 OID 17157)
-- Dependencies: 251
-- Data for Name: roles; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.roles (id, nombre) FROM stdin;
\.


--
-- TOC entry 5039 (class 0 OID 17163)
-- Dependencies: 253
-- Data for Name: stock_movimientos; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.stock_movimientos (id, idproducto, tipo, cantidad, referencia_tipo, referencia_id, idusuario, fecha, idalmacen) FROM stdin;
\.


--
-- TOC entry 5041 (class 0 OID 17173)
-- Dependencies: 255
-- Data for Name: usuario; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.usuario (id, nombre, dni, tel, mail, password_hash, idrol, email, last_login, is_active, failed_logins, created_at, updated_at) FROM stdin;
\.


--
-- TOC entry 5043 (class 0 OID 17183)
-- Dependencies: 257
-- Data for Name: ventas; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.ventas (id, idcliente, idusuario, fecha, total, numero_comprobante, tipo_comprobante, estado, id_listaprecio, moneda, observaciones, created_at, updated_at) FROM stdin;
\.


--
-- TOC entry 5045 (class 0 OID 17194)
-- Dependencies: 259
-- Data for Name: versionbasededatos; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.versionbasededatos (id, version, fecha) FROM stdin;
\.


--
-- TOC entry 5052 (class 0 OID 0)
-- Dependencies: 220
-- Name: almacenes_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.almacenes_id_seq', 1, false);


--
-- TOC entry 5053 (class 0 OID 0)
-- Dependencies: 222
-- Name: caja_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.caja_id_seq', 1, false);


--
-- TOC entry 5054 (class 0 OID 0)
-- Dependencies: 224
-- Name: cliente_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.cliente_id_seq', 1, false);


--
-- TOC entry 5055 (class 0 OID 0)
-- Dependencies: 226
-- Name: combopromocion_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.combopromocion_id_seq', 1, false);


--
-- TOC entry 5056 (class 0 OID 0)
-- Dependencies: 228
-- Name: detalleventas_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.detalleventas_id_seq', 1, false);


--
-- TOC entry 5057 (class 0 OID 0)
-- Dependencies: 230
-- Name: devoluciones_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.devoluciones_id_seq', 1, false);


--
-- TOC entry 5058 (class 0 OID 0)
-- Dependencies: 232
-- Name: formaspago_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.formaspago_id_seq', 1, false);


--
-- TOC entry 5059 (class 0 OID 0)
-- Dependencies: 234
-- Name: historialprecio_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.historialprecio_id_seq', 1, false);


--
-- TOC entry 5060 (class 0 OID 0)
-- Dependencies: 236
-- Name: listasprecios_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.listasprecios_id_seq', 1, false);


--
-- TOC entry 5061 (class 0 OID 0)
-- Dependencies: 238
-- Name: movimientoscaja_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.movimientoscaja_id_seq', 1, false);


--
-- TOC entry 5062 (class 0 OID 0)
-- Dependencies: 240
-- Name: pagos_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.pagos_id_seq', 1, false);


--
-- TOC entry 5063 (class 0 OID 0)
-- Dependencies: 242
-- Name: producto_proveedor_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.producto_proveedor_id_seq', 1, false);


--
-- TOC entry 5064 (class 0 OID 0)
-- Dependencies: 244
-- Name: productoproveedor_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.productoproveedor_id_seq', 1, false);


--
-- TOC entry 5065 (class 0 OID 0)
-- Dependencies: 246
-- Name: productos_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.productos_id_seq', 1, false);


--
-- TOC entry 5066 (class 0 OID 0)
-- Dependencies: 248
-- Name: promocionproductos_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.promocionproductos_id_seq', 1, false);


--
-- TOC entry 5067 (class 0 OID 0)
-- Dependencies: 250
-- Name: proveedores_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.proveedores_id_seq', 1, false);


--
-- TOC entry 5068 (class 0 OID 0)
-- Dependencies: 252
-- Name: roles_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.roles_id_seq', 1, false);


--
-- TOC entry 5069 (class 0 OID 0)
-- Dependencies: 254
-- Name: stock_movimientos_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.stock_movimientos_id_seq', 1, false);


--
-- TOC entry 5070 (class 0 OID 0)
-- Dependencies: 256
-- Name: usuario_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.usuario_id_seq', 1, false);


--
-- TOC entry 5071 (class 0 OID 0)
-- Dependencies: 258
-- Name: ventas_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.ventas_id_seq', 1, false);


--
-- TOC entry 5072 (class 0 OID 0)
-- Dependencies: 260
-- Name: versionbasededatos_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.versionbasededatos_id_seq', 1, false);


--
-- TOC entry 4788 (class 2606 OID 17201)
-- Name: migrations migrations_pkey; Type: CONSTRAINT; Schema: meta; Owner: postgres
--

ALTER TABLE ONLY meta.migrations
    ADD CONSTRAINT migrations_pkey PRIMARY KEY (version);


--
-- TOC entry 4790 (class 2606 OID 17203)
-- Name: almacenes almacenes_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.almacenes
    ADD CONSTRAINT almacenes_pkey PRIMARY KEY (id);


--
-- TOC entry 4792 (class 2606 OID 17205)
-- Name: caja caja_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.caja
    ADD CONSTRAINT caja_pkey PRIMARY KEY (id);


--
-- TOC entry 4794 (class 2606 OID 17207)
-- Name: cliente cliente_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.cliente
    ADD CONSTRAINT cliente_pkey PRIMARY KEY (id);


--
-- TOC entry 4796 (class 2606 OID 17209)
-- Name: combopromocion combopromocion_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.combopromocion
    ADD CONSTRAINT combopromocion_pkey PRIMARY KEY (id);


--
-- TOC entry 4798 (class 2606 OID 17211)
-- Name: detalleventas detalleventas_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.detalleventas
    ADD CONSTRAINT detalleventas_pkey PRIMARY KEY (id);


--
-- TOC entry 4800 (class 2606 OID 17213)
-- Name: devoluciones devoluciones_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.devoluciones
    ADD CONSTRAINT devoluciones_pkey PRIMARY KEY (id);


--
-- TOC entry 4802 (class 2606 OID 17215)
-- Name: formaspago formaspago_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.formaspago
    ADD CONSTRAINT formaspago_pkey PRIMARY KEY (id);


--
-- TOC entry 4804 (class 2606 OID 17217)
-- Name: historialprecio historialprecio_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.historialprecio
    ADD CONSTRAINT historialprecio_pkey PRIMARY KEY (id);


--
-- TOC entry 4806 (class 2606 OID 17219)
-- Name: listasprecios listasprecios_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.listasprecios
    ADD CONSTRAINT listasprecios_pkey PRIMARY KEY (id);


--
-- TOC entry 4808 (class 2606 OID 17221)
-- Name: movimientoscaja movimientoscaja_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.movimientoscaja
    ADD CONSTRAINT movimientoscaja_pkey PRIMARY KEY (id);


--
-- TOC entry 4810 (class 2606 OID 17223)
-- Name: pagos pagos_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.pagos
    ADD CONSTRAINT pagos_pkey PRIMARY KEY (id);


--
-- TOC entry 4812 (class 2606 OID 17225)
-- Name: producto_proveedor producto_proveedor_idproducto_idproveedor_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.producto_proveedor
    ADD CONSTRAINT producto_proveedor_idproducto_idproveedor_key UNIQUE (idproducto, idproveedor);


--
-- TOC entry 4814 (class 2606 OID 17227)
-- Name: producto_proveedor producto_proveedor_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.producto_proveedor
    ADD CONSTRAINT producto_proveedor_pkey PRIMARY KEY (id);


--
-- TOC entry 4816 (class 2606 OID 17229)
-- Name: productoproveedor productoproveedor_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.productoproveedor
    ADD CONSTRAINT productoproveedor_pkey PRIMARY KEY (id);


--
-- TOC entry 4818 (class 2606 OID 17231)
-- Name: productos productos_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.productos
    ADD CONSTRAINT productos_pkey PRIMARY KEY (id);


--
-- TOC entry 4820 (class 2606 OID 17233)
-- Name: promocionproductos promocionproductos_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.promocionproductos
    ADD CONSTRAINT promocionproductos_pkey PRIMARY KEY (id);


--
-- TOC entry 4822 (class 2606 OID 17235)
-- Name: proveedores proveedores_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.proveedores
    ADD CONSTRAINT proveedores_pkey PRIMARY KEY (id);


--
-- TOC entry 4824 (class 2606 OID 17237)
-- Name: roles roles_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.roles
    ADD CONSTRAINT roles_pkey PRIMARY KEY (id);


--
-- TOC entry 4826 (class 2606 OID 17239)
-- Name: stock_movimientos stock_movimientos_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.stock_movimientos
    ADD CONSTRAINT stock_movimientos_pkey PRIMARY KEY (id);


--
-- TOC entry 4828 (class 2606 OID 17241)
-- Name: usuario usuario_email_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.usuario
    ADD CONSTRAINT usuario_email_key UNIQUE (email);


--
-- TOC entry 4830 (class 2606 OID 17243)
-- Name: usuario usuario_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.usuario
    ADD CONSTRAINT usuario_pkey PRIMARY KEY (id);


--
-- TOC entry 4832 (class 2606 OID 17245)
-- Name: ventas ventas_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ventas
    ADD CONSTRAINT ventas_pkey PRIMARY KEY (id);


--
-- TOC entry 4834 (class 2606 OID 17247)
-- Name: versionbasededatos versionbasededatos_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.versionbasededatos
    ADD CONSTRAINT versionbasededatos_pkey PRIMARY KEY (id);


--
-- TOC entry 4835 (class 2606 OID 17248)
-- Name: caja caja_idusuario_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.caja
    ADD CONSTRAINT caja_idusuario_fkey FOREIGN KEY (idusuario) REFERENCES public.usuario(id);


--
-- TOC entry 4836 (class 2606 OID 17253)
-- Name: combopromocion combopromocion_idproducto_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.combopromocion
    ADD CONSTRAINT combopromocion_idproducto_fkey FOREIGN KEY (idproducto) REFERENCES public.productos(id);


--
-- TOC entry 4837 (class 2606 OID 17258)
-- Name: combopromocion combopromocion_idpromocion_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.combopromocion
    ADD CONSTRAINT combopromocion_idpromocion_fkey FOREIGN KEY (idpromocion) REFERENCES public.promocionproductos(id);


--
-- TOC entry 4838 (class 2606 OID 17263)
-- Name: detalleventas detalleventas_idproducto_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.detalleventas
    ADD CONSTRAINT detalleventas_idproducto_fkey FOREIGN KEY (idproducto) REFERENCES public.productos(id);


--
-- TOC entry 4839 (class 2606 OID 17268)
-- Name: detalleventas detalleventas_idventa_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.detalleventas
    ADD CONSTRAINT detalleventas_idventa_fkey FOREIGN KEY (idventa) REFERENCES public.ventas(id) ON DELETE RESTRICT;


--
-- TOC entry 4840 (class 2606 OID 17273)
-- Name: devoluciones devoluciones_iddetalle_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.devoluciones
    ADD CONSTRAINT devoluciones_iddetalle_fkey FOREIGN KEY (iddetalle) REFERENCES public.detalleventas(id);


--
-- TOC entry 4841 (class 2606 OID 17278)
-- Name: devoluciones devoluciones_idventa_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.devoluciones
    ADD CONSTRAINT devoluciones_idventa_fkey FOREIGN KEY (idventa) REFERENCES public.ventas(id);


--
-- TOC entry 4842 (class 2606 OID 17283)
-- Name: historialprecio historialprecio_idproducto_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.historialprecio
    ADD CONSTRAINT historialprecio_idproducto_fkey FOREIGN KEY (idproducto) REFERENCES public.productos(id);


--
-- TOC entry 4843 (class 2606 OID 17288)
-- Name: historialprecio historialprecio_idventa_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.historialprecio
    ADD CONSTRAINT historialprecio_idventa_fkey FOREIGN KEY (idventa) REFERENCES public.ventas(id);


--
-- TOC entry 4844 (class 2606 OID 17293)
-- Name: movimientoscaja movimientoscaja_idusuario_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.movimientoscaja
    ADD CONSTRAINT movimientoscaja_idusuario_fkey FOREIGN KEY (idusuario) REFERENCES public.usuario(id);


--
-- TOC entry 4845 (class 2606 OID 17298)
-- Name: pagos pagos_idformapago_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.pagos
    ADD CONSTRAINT pagos_idformapago_fkey FOREIGN KEY (idformapago) REFERENCES public.formaspago(id);


--
-- TOC entry 4846 (class 2606 OID 17303)
-- Name: pagos pagos_idventa_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.pagos
    ADD CONSTRAINT pagos_idventa_fkey FOREIGN KEY (idventa) REFERENCES public.ventas(id);


--
-- TOC entry 4847 (class 2606 OID 17308)
-- Name: producto_proveedor producto_proveedor_idproducto_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.producto_proveedor
    ADD CONSTRAINT producto_proveedor_idproducto_fkey FOREIGN KEY (idproducto) REFERENCES public.productos(id);


--
-- TOC entry 4848 (class 2606 OID 17313)
-- Name: producto_proveedor producto_proveedor_idproveedor_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.producto_proveedor
    ADD CONSTRAINT producto_proveedor_idproveedor_fkey FOREIGN KEY (idproveedor) REFERENCES public.proveedores(id);


--
-- TOC entry 4849 (class 2606 OID 17318)
-- Name: productoproveedor productoproveedor_idproducto_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.productoproveedor
    ADD CONSTRAINT productoproveedor_idproducto_fkey FOREIGN KEY (idproducto) REFERENCES public.productos(id);


--
-- TOC entry 4850 (class 2606 OID 17323)
-- Name: productoproveedor productoproveedor_idproveedor_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.productoproveedor
    ADD CONSTRAINT productoproveedor_idproveedor_fkey FOREIGN KEY (idproveedor) REFERENCES public.proveedores(id);


--
-- TOC entry 4851 (class 2606 OID 17328)
-- Name: promocionproductos promocionproductos_idproducto_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.promocionproductos
    ADD CONSTRAINT promocionproductos_idproducto_fkey FOREIGN KEY (idproducto) REFERENCES public.productos(id);


--
-- TOC entry 4852 (class 2606 OID 17333)
-- Name: stock_movimientos stock_movimientos_idalmacen_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.stock_movimientos
    ADD CONSTRAINT stock_movimientos_idalmacen_fkey FOREIGN KEY (idalmacen) REFERENCES public.almacenes(id);


--
-- TOC entry 4853 (class 2606 OID 17338)
-- Name: stock_movimientos stock_movimientos_idproducto_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.stock_movimientos
    ADD CONSTRAINT stock_movimientos_idproducto_fkey FOREIGN KEY (idproducto) REFERENCES public.productos(id);


--
-- TOC entry 4854 (class 2606 OID 17343)
-- Name: stock_movimientos stock_movimientos_idusuario_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.stock_movimientos
    ADD CONSTRAINT stock_movimientos_idusuario_fkey FOREIGN KEY (idusuario) REFERENCES public.usuario(id);


--
-- TOC entry 4855 (class 2606 OID 17348)
-- Name: usuario usuario_idrol_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.usuario
    ADD CONSTRAINT usuario_idrol_fkey FOREIGN KEY (idrol) REFERENCES public.roles(id);


--
-- TOC entry 4856 (class 2606 OID 17353)
-- Name: ventas ventas_id_listaprecio_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ventas
    ADD CONSTRAINT ventas_id_listaprecio_fkey FOREIGN KEY (id_listaprecio) REFERENCES public.listasprecios(id);


--
-- TOC entry 4857 (class 2606 OID 17358)
-- Name: ventas ventas_idcliente_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ventas
    ADD CONSTRAINT ventas_idcliente_fkey FOREIGN KEY (idcliente) REFERENCES public.cliente(id) ON DELETE RESTRICT;


--
-- TOC entry 4858 (class 2606 OID 17363)
-- Name: ventas ventas_idusuario_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ventas
    ADD CONSTRAINT ventas_idusuario_fkey FOREIGN KEY (idusuario) REFERENCES public.usuario(id);


-- Completed on 2025-09-10 14:51:55

--
-- PostgreSQL database dump complete
--

\unrestrict 3Z9tBV2xEwFosSeXKwnbcPfhGdny55irS8bOadDvSchfcmfVwd0oWt1n0s382wk

