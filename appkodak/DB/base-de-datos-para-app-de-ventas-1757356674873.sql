--
-- PostgreSQL database dump
--

-- Dumped from database version 16.3 (PGlite 0.2.0)
-- Dumped by pg_dump version 16.4

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'SQL_ASCII';
SET standard_conforming_strings = off;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET escape_string_warning = off;
SET row_security = off;

--
-- Name: meta; Type: SCHEMA; Schema: -; Owner: postgres
--

CREATE SCHEMA meta;


ALTER SCHEMA meta OWNER TO postgres;

--
-- Name: vector; Type: EXTENSION; Schema: -; Owner: -
--

CREATE EXTENSION IF NOT EXISTS vector WITH SCHEMA public;


--
-- Name: EXTENSION vector; Type: COMMENT; Schema: -; Owner: 
--

COMMENT ON EXTENSION vector IS 'vector data type and ivfflat and hnsw access methods';


SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: embeddings; Type: TABLE; Schema: meta; Owner: postgres
--

CREATE TABLE meta.embeddings (
    id bigint NOT NULL,
    created_at timestamp with time zone DEFAULT now() NOT NULL,
    content text NOT NULL,
    embedding public.vector(384) NOT NULL
);


ALTER TABLE meta.embeddings OWNER TO postgres;

--
-- Name: embeddings_id_seq; Type: SEQUENCE; Schema: meta; Owner: postgres
--

ALTER TABLE meta.embeddings ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME meta.embeddings_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: migrations; Type: TABLE; Schema: meta; Owner: postgres
--

CREATE TABLE meta.migrations (
    version text NOT NULL,
    name text,
    applied_at timestamp with time zone DEFAULT now() NOT NULL
);


ALTER TABLE meta.migrations OWNER TO postgres;

--
-- Name: almacenes; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.almacenes (
    id bigint NOT NULL,
    nombre text NOT NULL,
    ubicacion text
);


ALTER TABLE public.almacenes OWNER TO postgres;

--
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
-- Name: formaspago; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.formaspago (
    id bigint NOT NULL,
    metodo text NOT NULL
);


ALTER TABLE public.formaspago OWNER TO postgres;

--
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
-- Name: roles; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.roles (
    id bigint NOT NULL,
    nombre text NOT NULL
);


ALTER TABLE public.roles OWNER TO postgres;

--
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
-- Name: versionbasededatos; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.versionbasededatos (
    id bigint NOT NULL,
    version text NOT NULL,
    fecha date
);


ALTER TABLE public.versionbasededatos OWNER TO postgres;

--
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
-- Data for Name: embeddings; Type: TABLE DATA; Schema: meta; Owner: postgres
--



--
-- Data for Name: migrations; Type: TABLE DATA; Schema: meta; Owner: postgres
--

INSERT INTO meta.migrations VALUES ('202407160001', 'embeddings', '2025-09-08 14:32:44.438+00');


--
-- Data for Name: almacenes; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: caja; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: cliente; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: combopromocion; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: detalleventas; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: devoluciones; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: formaspago; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: historialprecio; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: listasprecios; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: movimientoscaja; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: pagos; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: producto_proveedor; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: productoproveedor; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: productos; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: promocionproductos; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: proveedores; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: roles; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: stock_movimientos; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: usuario; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: ventas; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: versionbasededatos; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Name: embeddings_id_seq; Type: SEQUENCE SET; Schema: meta; Owner: postgres
--

SELECT pg_catalog.setval('meta.embeddings_id_seq', 1, false);


--
-- Name: almacenes_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.almacenes_id_seq', 1, false);


--
-- Name: caja_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.caja_id_seq', 1, false);


--
-- Name: cliente_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.cliente_id_seq', 1, false);


--
-- Name: combopromocion_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.combopromocion_id_seq', 1, false);


--
-- Name: detalleventas_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.detalleventas_id_seq', 1, false);


--
-- Name: devoluciones_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.devoluciones_id_seq', 1, false);


--
-- Name: formaspago_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.formaspago_id_seq', 1, false);


--
-- Name: historialprecio_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.historialprecio_id_seq', 1, false);


--
-- Name: listasprecios_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.listasprecios_id_seq', 1, false);


--
-- Name: movimientoscaja_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.movimientoscaja_id_seq', 1, false);


--
-- Name: pagos_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.pagos_id_seq', 1, false);


--
-- Name: producto_proveedor_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.producto_proveedor_id_seq', 1, false);


--
-- Name: productoproveedor_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.productoproveedor_id_seq', 1, false);


--
-- Name: productos_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.productos_id_seq', 1, false);


--
-- Name: promocionproductos_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.promocionproductos_id_seq', 1, false);


--
-- Name: proveedores_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.proveedores_id_seq', 1, false);


--
-- Name: roles_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.roles_id_seq', 1, false);


--
-- Name: stock_movimientos_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.stock_movimientos_id_seq', 1, false);


--
-- Name: usuario_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.usuario_id_seq', 1, false);


--
-- Name: ventas_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.ventas_id_seq', 1, false);


--
-- Name: versionbasededatos_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.versionbasededatos_id_seq', 1, false);


--
-- Name: embeddings embeddings_pkey; Type: CONSTRAINT; Schema: meta; Owner: postgres
--

ALTER TABLE ONLY meta.embeddings
    ADD CONSTRAINT embeddings_pkey PRIMARY KEY (id);


--
-- Name: migrations migrations_pkey; Type: CONSTRAINT; Schema: meta; Owner: postgres
--

ALTER TABLE ONLY meta.migrations
    ADD CONSTRAINT migrations_pkey PRIMARY KEY (version);


--
-- Name: almacenes almacenes_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.almacenes
    ADD CONSTRAINT almacenes_pkey PRIMARY KEY (id);


--
-- Name: caja caja_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.caja
    ADD CONSTRAINT caja_pkey PRIMARY KEY (id);


--
-- Name: cliente cliente_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.cliente
    ADD CONSTRAINT cliente_pkey PRIMARY KEY (id);


--
-- Name: combopromocion combopromocion_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.combopromocion
    ADD CONSTRAINT combopromocion_pkey PRIMARY KEY (id);


--
-- Name: detalleventas detalleventas_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.detalleventas
    ADD CONSTRAINT detalleventas_pkey PRIMARY KEY (id);


--
-- Name: devoluciones devoluciones_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.devoluciones
    ADD CONSTRAINT devoluciones_pkey PRIMARY KEY (id);


--
-- Name: formaspago formaspago_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.formaspago
    ADD CONSTRAINT formaspago_pkey PRIMARY KEY (id);


--
-- Name: historialprecio historialprecio_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.historialprecio
    ADD CONSTRAINT historialprecio_pkey PRIMARY KEY (id);


--
-- Name: listasprecios listasprecios_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.listasprecios
    ADD CONSTRAINT listasprecios_pkey PRIMARY KEY (id);


--
-- Name: movimientoscaja movimientoscaja_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.movimientoscaja
    ADD CONSTRAINT movimientoscaja_pkey PRIMARY KEY (id);


--
-- Name: pagos pagos_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.pagos
    ADD CONSTRAINT pagos_pkey PRIMARY KEY (id);


--
-- Name: producto_proveedor producto_proveedor_idproducto_idproveedor_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.producto_proveedor
    ADD CONSTRAINT producto_proveedor_idproducto_idproveedor_key UNIQUE (idproducto, idproveedor);


--
-- Name: producto_proveedor producto_proveedor_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.producto_proveedor
    ADD CONSTRAINT producto_proveedor_pkey PRIMARY KEY (id);


--
-- Name: productoproveedor productoproveedor_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.productoproveedor
    ADD CONSTRAINT productoproveedor_pkey PRIMARY KEY (id);


--
-- Name: productos productos_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.productos
    ADD CONSTRAINT productos_pkey PRIMARY KEY (id);


--
-- Name: promocionproductos promocionproductos_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.promocionproductos
    ADD CONSTRAINT promocionproductos_pkey PRIMARY KEY (id);


--
-- Name: proveedores proveedores_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.proveedores
    ADD CONSTRAINT proveedores_pkey PRIMARY KEY (id);


--
-- Name: roles roles_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.roles
    ADD CONSTRAINT roles_pkey PRIMARY KEY (id);


--
-- Name: stock_movimientos stock_movimientos_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.stock_movimientos
    ADD CONSTRAINT stock_movimientos_pkey PRIMARY KEY (id);


--
-- Name: usuario usuario_email_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.usuario
    ADD CONSTRAINT usuario_email_key UNIQUE (email);


--
-- Name: usuario usuario_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.usuario
    ADD CONSTRAINT usuario_pkey PRIMARY KEY (id);


--
-- Name: ventas ventas_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ventas
    ADD CONSTRAINT ventas_pkey PRIMARY KEY (id);


--
-- Name: versionbasededatos versionbasededatos_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.versionbasededatos
    ADD CONSTRAINT versionbasededatos_pkey PRIMARY KEY (id);


--
-- Name: caja caja_idusuario_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.caja
    ADD CONSTRAINT caja_idusuario_fkey FOREIGN KEY (idusuario) REFERENCES public.usuario(id);


--
-- Name: combopromocion combopromocion_idproducto_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.combopromocion
    ADD CONSTRAINT combopromocion_idproducto_fkey FOREIGN KEY (idproducto) REFERENCES public.productos(id);


--
-- Name: combopromocion combopromocion_idpromocion_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.combopromocion
    ADD CONSTRAINT combopromocion_idpromocion_fkey FOREIGN KEY (idpromocion) REFERENCES public.promocionproductos(id);


--
-- Name: detalleventas detalleventas_idproducto_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.detalleventas
    ADD CONSTRAINT detalleventas_idproducto_fkey FOREIGN KEY (idproducto) REFERENCES public.productos(id);


--
-- Name: detalleventas detalleventas_idventa_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.detalleventas
    ADD CONSTRAINT detalleventas_idventa_fkey FOREIGN KEY (idventa) REFERENCES public.ventas(id) ON DELETE RESTRICT;


--
-- Name: devoluciones devoluciones_iddetalle_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.devoluciones
    ADD CONSTRAINT devoluciones_iddetalle_fkey FOREIGN KEY (iddetalle) REFERENCES public.detalleventas(id);


--
-- Name: devoluciones devoluciones_idventa_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.devoluciones
    ADD CONSTRAINT devoluciones_idventa_fkey FOREIGN KEY (idventa) REFERENCES public.ventas(id);


--
-- Name: historialprecio historialprecio_idproducto_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.historialprecio
    ADD CONSTRAINT historialprecio_idproducto_fkey FOREIGN KEY (idproducto) REFERENCES public.productos(id);


--
-- Name: historialprecio historialprecio_idventa_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.historialprecio
    ADD CONSTRAINT historialprecio_idventa_fkey FOREIGN KEY (idventa) REFERENCES public.ventas(id);


--
-- Name: movimientoscaja movimientoscaja_idusuario_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.movimientoscaja
    ADD CONSTRAINT movimientoscaja_idusuario_fkey FOREIGN KEY (idusuario) REFERENCES public.usuario(id);


--
-- Name: pagos pagos_idformapago_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.pagos
    ADD CONSTRAINT pagos_idformapago_fkey FOREIGN KEY (idformapago) REFERENCES public.formaspago(id);


--
-- Name: pagos pagos_idventa_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.pagos
    ADD CONSTRAINT pagos_idventa_fkey FOREIGN KEY (idventa) REFERENCES public.ventas(id);


--
-- Name: producto_proveedor producto_proveedor_idproducto_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.producto_proveedor
    ADD CONSTRAINT producto_proveedor_idproducto_fkey FOREIGN KEY (idproducto) REFERENCES public.productos(id);


--
-- Name: producto_proveedor producto_proveedor_idproveedor_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.producto_proveedor
    ADD CONSTRAINT producto_proveedor_idproveedor_fkey FOREIGN KEY (idproveedor) REFERENCES public.proveedores(id);


--
-- Name: productoproveedor productoproveedor_idproducto_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.productoproveedor
    ADD CONSTRAINT productoproveedor_idproducto_fkey FOREIGN KEY (idproducto) REFERENCES public.productos(id);


--
-- Name: productoproveedor productoproveedor_idproveedor_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.productoproveedor
    ADD CONSTRAINT productoproveedor_idproveedor_fkey FOREIGN KEY (idproveedor) REFERENCES public.proveedores(id);


--
-- Name: promocionproductos promocionproductos_idproducto_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.promocionproductos
    ADD CONSTRAINT promocionproductos_idproducto_fkey FOREIGN KEY (idproducto) REFERENCES public.productos(id);


--
-- Name: stock_movimientos stock_movimientos_idalmacen_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.stock_movimientos
    ADD CONSTRAINT stock_movimientos_idalmacen_fkey FOREIGN KEY (idalmacen) REFERENCES public.almacenes(id);


--
-- Name: stock_movimientos stock_movimientos_idproducto_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.stock_movimientos
    ADD CONSTRAINT stock_movimientos_idproducto_fkey FOREIGN KEY (idproducto) REFERENCES public.productos(id);


--
-- Name: stock_movimientos stock_movimientos_idusuario_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.stock_movimientos
    ADD CONSTRAINT stock_movimientos_idusuario_fkey FOREIGN KEY (idusuario) REFERENCES public.usuario(id);


--
-- Name: usuario usuario_idrol_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.usuario
    ADD CONSTRAINT usuario_idrol_fkey FOREIGN KEY (idrol) REFERENCES public.roles(id);


--
-- Name: ventas ventas_id_listaprecio_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ventas
    ADD CONSTRAINT ventas_id_listaprecio_fkey FOREIGN KEY (id_listaprecio) REFERENCES public.listasprecios(id);


--
-- Name: ventas ventas_idcliente_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ventas
    ADD CONSTRAINT ventas_idcliente_fkey FOREIGN KEY (idcliente) REFERENCES public.cliente(id) ON DELETE RESTRICT;


--
-- Name: ventas ventas_idusuario_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ventas
    ADD CONSTRAINT ventas_idusuario_fkey FOREIGN KEY (idusuario) REFERENCES public.usuario(id);


--
-- PostgreSQL database dump complete
--

